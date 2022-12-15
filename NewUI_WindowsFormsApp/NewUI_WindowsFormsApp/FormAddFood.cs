using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace NewUI_WindowsFormsApp
{
    public partial class FormAddFood : Form
    {
        string myDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";

        public FormAddFood()
        {
            InitializeComponent();
        }

        private void FormAddFood_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            產生品項列表();
        }

        void 產生品項列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from menu;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介物件
                dt.Load(reader);
                dgv品項列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }



        private void btn清除欄位_Click(object sender, EventArgs e)
        {
            txtShopID.Text = "";
            txtShopName.Text = "";
            txtFoodID.Text = "";
            txtFoodName.Text = "";
            txtPrice.Text = "";
            pictureBox1.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtFoodName.Text != "") && (txtPrice.Text != ""))
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into menu values(@NewShopID,@NewShopName,@NewName, @NewPrice, @NewPimage);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewShopID", txtShopID.Text);
                    cmd.Parameters.AddWithValue("@NewShopName", txtShopName.Text);
                    cmd.Parameters.AddWithValue("@NewName", txtFoodName.Text);
                    cmd.Parameters.AddWithValue("@NewPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@NewPimage", image_name);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料新增成功");
                    產生品項列表();
                    txtShopID.Text = "";
                    txtShopName.Text = "";
                    txtFoodID.Text = "";
                    txtFoodName.Text = "";
                    txtPrice.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("請輸入餐點名稱及價格!");
                }
            }
            catch
            {
                MessageBox.Show("此餐點已新增!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtFoodID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from menu where menuID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                txtShopID.Text = "";
                txtShopName.Text = "";
                txtFoodID.Text = "";
                txtFoodName.Text = "";
                txtPrice.Text = "";
                pictureBox1.Image = null;


                MessageBox.Show(rows.ToString() + "筆資料刪除成功");
                產生品項列表();

            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtFoodID.Text, out intID);

            if (intID > 0)
            {
                if ((txtFoodName.Text != "") && (txtPrice.Text != ""))
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update menu set pname=@NewName, price=@NewPrice  where menuID=@SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewName", txtFoodName.Text);
                    cmd.Parameters.AddWithValue("@NewPrice", txtPrice.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(rows.ToString() + "筆資料修改成功");
                    產生品項列表();
                    txtShopID.Text = "";
                    txtShopName.Text = "";
                    txtFoodID.Text = "";
                    txtFoodName.Text = "";
                    txtPrice.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("請填寫品項名稱及價格!");
                }
            }
        }

        private void btn選擇圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpg;*jpeg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExtension = Path.GetExtension(f.SafeFileName);//副檔名
                Random myRnd = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRnd.Next(1000, 9999).ToString() + fileExtension;
            }
        }

        private void dgv品項列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            int selID = 0;
            string strSelID = dgv品項列表.Rows[e.RowIndex].Cells[0].Value.ToString();
            Int32.TryParse(strSelID, out selID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from menu where menuID = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", selID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtFoodID.Text = string.Format("{0}", reader["menuID"]);
                txtShopID.Text = string.Format("{0}", reader["shopID"]);
                txtShopName.Text = (string)reader["shopName"];
                txtFoodName.Text = (string)reader["pname"];
                txtPrice.Text = string.Format("{0}", reader["price"]);
                image_name = (string)reader["pimage"];
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
            }
            reader.Close();
            con.Close();
        }
    }
}

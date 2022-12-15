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

namespace NewUI_WindowsFormsApp
{
    public partial class FormOrderFood : Form
    {
        string myDBConnectionString = "";
        List<string> listProductName = new List<string>();
        List<string> listProductPrice = new List<string>();
        List<int> listProductID = new List<int>();
        List<string> listShopName = new List<string>();
        int amount = 1;
        int selID = 0;

        public FormOrderFood()
        {
            InitializeComponent();
        }

        private void FormOrderFood_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();
            讀取資料庫();
            產生圖片ListView();
            產生訂餐明細();
        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from menu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\"; //相對目錄 也可以用cd槽
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listProductID.Add((int)reader["menuID"]);
                listShopName.Add((string)reader["shopName"]);
                listProductName.Add((string)reader["pname"]);
                listProductPrice.Add((string)reader["price"]);
                image_name = (string)reader["pimage"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name)); //讀取圖檔
                i += 1; //可以搭配換頁效果
            }
            
            reader.Close();
            con.Close();
        }

        void 產生圖片ListView()
        {
            listView品項.Clear();
            listView品項.View = View.LargeIcon; //顯示方式:list,largeIcon,smallIcon,tile(20x20)
            imageList1.ImageSize = new Size(120, 120);
            listView品項.LargeImageList = imageList1; //儲存大圖的來源

            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem(); //圖片顯示單元物件
                item.ImageIndex = i;
                item.Font = new Font("標楷體", 14, FontStyle.Regular); //圖片文字設定
                item.Text = listProductName[i];
                item.Tag = listProductID[i];
                listView品項.Items.Add(item);
            }
        }

        private void listView品項_ItemActivate_1(object sender, EventArgs e)
        {
            int selMenuID = (int)listView品項.SelectedItems[0].Tag;

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from menu where menuID=@SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", selMenuID);
            SqlDataReader reader = cmd.ExecuteReader();
            amount = 1;

            if (reader.Read())
            {
                txt店名.Text = (string)reader["shopName"];
                txt品名.Text = (string)reader["pname"];
                txt單價.Text = (string)reader["price"];
                txt數量.Text = amount.ToString();
            }
            reader.Close();
            con.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txt數量.Text != "") && (txt品名.Text != "") && (Formlogin.userName!= ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into orderInfo values (@NewName,@NewClass,@NewShop," +
                    "@NewItem,@NewPrice,@NewAmount);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", Formlogin.userName);
                cmd.Parameters.AddWithValue("@NewClass",Formlogin.userClass);
                cmd.Parameters.AddWithValue("@NewShop", txt店名.Text);
                cmd.Parameters.AddWithValue("@NewItem", txt品名.Text);
                cmd.Parameters.AddWithValue("@NewPrice", txt單價.Text);
                cmd.Parameters.AddWithValue("@NewAmount", txt數量.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(rows.ToString() + "筆資料新增成功");

                產生訂餐明細();

                txt店名.Text="";
                txt品名.Text = "";
                txt單價.Text = "";
                txt數量.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("所有欄位必填!", "錯誤訊息");
            }
        }

        void 產生訂餐明細()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from orderInfo where orderName=@SearchName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", Formlogin.userName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介物件
                dt.Load(reader); //讀取reader內容進入dataTable物件
                dgv訂單明細.DataSource = dt; //指定讀取來源為dataTable物件
            }
            reader.Close();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定取消此筆訂單?", "取消訂單", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (R == DialogResult.OK)
            {
                if (selID > 0)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "delete from orderInfo where orderID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", selID);

                    int rows = cmd.ExecuteNonQuery(); //ExecuteNonQuery只執行不查詢 會回傳rows
                    con.Close();
                    MessageBox.Show(rows.ToString() + "筆訂單取消成功");
                    產生訂餐明細();
                }
                else
                {
                    MessageBox.Show("請選擇欲取消訂單");
                }
            }
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(txt數量.Text, out amount);
        }

        private void dgv訂單明細_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; } //避免點到欄位會當掉
            string strSelID = dgv訂單明細.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e是點擊的事件 e.RowIndex取得點擊的列數 Cells儲存格的集合 Cells[0]是id
            Int32.TryParse(strSelID, out selID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from orderInfo where orderID = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", selID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txt店名.Text = string.Format("{0}", reader["shopName"]);
                txt品名.Text = string.Format("{0}", reader["orderItem"]);
                txt單價.Text = string.Format("{0}", reader["price"]);
                txt數量.Text = string.Format("{0}", reader["amount"]);
            }
            reader.Close();
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt店名.Text = "";
            txt品名.Text = "";
            txt單價.Text = "";
            amount = 1;
            txt數量.Text = amount.ToString();
        }

        private void btn加_Click(object sender, EventArgs e)
        {
            amount += 1;
            string strAmount = amount.ToString();
            txt數量.Text = strAmount;
        }

        private void btn減_Click(object sender, EventArgs e)
        {
            if (amount > 1)
            {
                amount -= 1;
                string strAmount = amount.ToString();
                txt數量.Text = strAmount;
            }
            else
            {
                txt數量.Text = "1";
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if ((txt數量.Text != "") && (txt品名.Text != "") && (Formlogin.userName != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into favorite values (@NewID,@NewName,@NewShop,@NewItem,@NewPrice,@NewAmount);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", Formlogin.userID);
                cmd.Parameters.AddWithValue("@NewName", Formlogin.userName);
                cmd.Parameters.AddWithValue("@NewShop", txt店名.Text);
                cmd.Parameters.AddWithValue("@NewItem", txt品名.Text);
                cmd.Parameters.AddWithValue("@NewPrice", txt單價.Text);
                cmd.Parameters.AddWithValue("@NewAmount", txt數量.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("成功加入我的最愛");
            }
        }
    }
}

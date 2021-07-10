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
    
    public partial class FormFavorite : Form
    {
        string myDBConnectionString = "";
        public FormFavorite()
        {
            InitializeComponent();
        }

        private void FormFavorite_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;

            myDBConnectionString = scsb.ToString();
            產生我的最愛明細();
        }

        void 產生我的最愛明細()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from favorite where stuName = @SearchName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", Formlogin.userName);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介物件
                dt.Load(reader); //讀取reader內容進入dataTable物件
                dgv最愛.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dgv最愛_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; } //避免點到欄位會當掉
            string selName = dgv最愛.Rows[e.RowIndex].Cells[3].Value.ToString();
            //e是點擊的事件 e.RowIndex取得點擊的列數 Cells儲存格的集合 Cells[1]是品項名

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from favorite where foodName = @SearchFood";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchFood", selName);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txt店名.Text = string.Format("{0}", reader["shopName"]);
                txt品名.Text = string.Format("{0}", reader["foodName"]);
                txt單價.Text = string.Format("{0}", reader["price"]);
                txt數量.Text = string.Format("{0}", reader["amount"]);
            }
            reader.Close();
            con.Close();
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定刪除此筆最愛?", "從我的最愛刪除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (R == DialogResult.OK)
            {
                if (txt品名.Text != "")
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "delete from favorite where foodName = @SearchFood";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchFood", txt品名.Text);
                    int rows = cmd.ExecuteNonQuery(); //ExecuteNonQuery只執行不查詢 會回傳rows
                    con.Close();
                    MessageBox.Show("刪除最愛成功");
                    產生我的最愛明細();
                }
                else
                {
                    MessageBox.Show("請選擇欲刪除的品項");
                }
            }
        }

        private void btn訂餐_Click(object sender, EventArgs e)
        {
            if ((txt數量.Text != "") && (txt品名.Text != "") && (Formlogin.userName != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into orderInfo values (@NewName,@NewClass,@NewShop," +
                    "@NewItem,@NewPrice,@NewAmount);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", Formlogin.userName);
                cmd.Parameters.AddWithValue("@NewClass", Formlogin.userClass);
                cmd.Parameters.AddWithValue("@NewShop", txt店名.Text);
                cmd.Parameters.AddWithValue("@NewItem", txt品名.Text);
                cmd.Parameters.AddWithValue("@NewPrice", txt單價.Text);
                cmd.Parameters.AddWithValue("@NewAmount", txt數量.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("訂餐成功");
            }
        }
    }
}

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
    public partial class FormOrderList : Form
    {
        string myDBConnectionString = "";
        string selshop = "shopName";

        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            產生店家資料();
            讀取店家名();
            產生統計結果();
        }

        void 產生店家資料()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select shopName as 店名,phone as 電話,address as 地址 from shop";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介物件
                dt.Load(reader); //讀取reader內容進入dataTable物件
                dgv店家資訊.DataSource = dt; //指定讀取來源為dataTable物件                
            }
            reader.Close();
            con.Close();
        }

        void 讀取店家名()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select distinct shopName from menu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbox店名.Items.Add((string)reader["shopName"]);
            }
            reader.Close();
            con.Close();
        }

        void 產生統計結果()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select orderItem as 品項,price as 單價,sum(amount) as 統計 from orderInfo where shopName=@SearchShop group by orderItem,price;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchShop", selshop);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介物件
                dt.Load(reader); //讀取reader內容進入dataTable物件
                dgv統計結果.DataSource = dt; //指定讀取來源為dataTable物件                  
            }
            else
            {
                dgv統計結果.DataSource = "";
            }
            reader.Close();
            con.Close();
        }



        private void cbox店名_SelectedIndexChanged(object sender, EventArgs e)
        {
            selshop = cbox店名.SelectedItem.ToString();
            lbl列表標題.Text = $"{selshop} 統計結果";
            產生統計結果();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select sum(price*amount)as 總額 from orderInfo where shopName=@SearchShop group by shopName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchShop", selshop);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt總額.Text = reader["總額"].ToString();
            }
            else
            {
                txt總額.Text = "0";
            }
            reader.Close();
            con.Close();
        }

        private void btn列印結果_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\iii\downloads\";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum.ToString() + @"訂購檔.txt";
            string str完整路徑檔 = str檔案路徑 + str檔名; //預設檔名

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Txt File|*.txt"; //預設存成txt檔

            DialogResult R = sfd.ShowDialog(); //顯示結果對話框(按確定則回傳OK,取消cancel)

            if (R == DialogResult.OK)
            { //存檔
                str完整路徑檔 = sfd.FileName;  //檔案名稱欄位(可以指定也可以讀取)
                                          //代表使用者key入的檔案名稱+路徑
            }
            else
            { //取消
                return;
            }

            List<string> lines訂購資訊 = new List<string>();
            lines訂購資訊.Add("*************" + cbox店名.SelectedItem + " 便當訂購單*************");
            lines訂購資訊.Add("===============================================");
            lines訂購資訊.Add("-----------------------------------------------");
            lines訂購資訊.Add("<<訂購品項>>");

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select orderItem as 品項,price as 單價,sum(amount) as 統計 from orderInfo where shopName=@SearchShop group by orderItem,price;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchShop", selshop);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lines訂購資訊.Add(reader["品項"] + " " + reader["單價"] + "元 " + reader["統計"] + "個");
            }
            reader.Close();
            con.Close();

            lines訂購資訊.Add("----------------------------------------------");
            lines訂購資訊.Add("總價" + txt總額.Text + "元");
            lines訂購資訊.Add("==============================================");

            System.IO.File.WriteAllLines(str完整路徑檔, lines訂購資訊, Encoding.UTF8); //存取所有資訊
            MessageBox.Show("存檔成功");
        }

        private void btn總明細_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\iii\downloads\";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum.ToString() + @"訂購檔.txt";
            string str完整路徑檔 = str檔案路徑 + str檔名; //預設檔名

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Txt File|*.txt"; //預設存成txt檔

            DialogResult R = sfd.ShowDialog(); //顯示結果對話框(按確定則回傳OK,取消cancel)

            if (R == DialogResult.OK)
            { //存檔
                str完整路徑檔 = sfd.FileName;  //檔案名稱欄位(可以指定也可以讀取)
                                          //代表使用者key入的檔案名稱+路徑
            }
            else
            { //取消
                return;
            }

            List<string> lines訂購明細 = new List<string>();
            lines訂購明細.Add("*************便當訂購總明細表*****************");
            lines訂購明細.Add("==============================================");
            lines訂購明細.Add("----------------------------------------------");

            int total = 0;
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select orderName as 姓名 , class as 班級,orderItem as 品項,price as 單價 ,amount as 數量 from orderInfo;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lines訂購明細.Add($"{reader["姓名"]} {reader["班級"]} {reader["品項"] }  {reader["單價"] }元  {reader["數量"]}個");
                int 單價 =(int) reader["單價"];
                int 數量 = (int)reader["數量"];
                total += 單價 * 數量;
            }
            reader.Close();
            con.Close();

            lines訂購明細.Add("----------------------------------------------");
            lines訂購明細.Add("總價" + total + "元");
            lines訂購明細.Add("==============================================");

            System.IO.File.WriteAllLines(str完整路徑檔, lines訂購明細, Encoding.UTF8); //存取所有資訊
            MessageBox.Show("存檔成功");
        }
    }
}
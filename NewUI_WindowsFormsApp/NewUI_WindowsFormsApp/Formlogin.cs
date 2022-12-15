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
    public partial class Formlogin : Form
    {
        public static string userName = "";
        public static string userClass = "";
        public static bool is值日生 = false;
        public static bool is管理者 = false;
        public static int userID = 0;

        string myDBConnectionString = "";
        public Formlogin()
        {
            InitializeComponent();
        }
        

        private void Formlogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        void 讀取成員()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from student where stuName = @SearchName and stuID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", txtName.Text);
            cmd.Parameters.AddWithValue("@SearchID", txtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                userID = (int)reader["stuID"];
                userName = (string)reader["stuName"];
                userClass = (string)reader["stuClass"];
                is值日生 = (bool)reader["值日生"];
                is管理者 = (bool)reader["管理者"];
                if (is值日生)
                {
                    MessageBox.Show("你是值日生!");
                }
                if (is管理者)
                {
                    MessageBox.Show("歡迎管理者...");
                }

                MessageBox.Show("登入成功");
                lblWelcome.Text = $"Welcome，{userName}！！";
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤！");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPassword.Text != ""))
            {
                讀取成員();
                txtName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
            
        }
    }
}

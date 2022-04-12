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
    public partial class FormHome : Form
    {

        string myDBConnectionString = "";

        public FormHome()
        {
            InitializeComponent();
        }


        private void FormHome_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            openChildForm(new Formlogin());
            值日生顯示();
        }

        void 值日生顯示()
        {
            cbox值日生.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select stuName from student where 值日生 = 'true';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbox值日生.Items.Add((string)reader["stuName"]);
            }
            reader.Close();
            con.Close();
        }

        //子表單切換
        private Form activeForm = null; //確認表單是否開啟
        private void openChildForm(Form childForm) //開啟子表單方法
        {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm; //若表單未開啟，將表單名指定給變數
            childForm.TopLevel = false; //最上層視窗通常用來做為應用程式中的主要表單，故子表單不能設為最上層表單
            childForm.FormBorderStyle = FormBorderStyle.None; //設定子表單邊框為無
            childForm.Dock = DockStyle.Fill; //設定子表單位置
            panelChildForm.Controls.Add(childForm); //將表單加入panel顯示
            panelChildForm.Tag = childForm; //將標籤設為子表單名
            childForm.BringToFront(); //將表單放置到前面
            childForm.Show(); //開啟表單

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrderFood()); //呼叫開啟子表單方法，建立新表單物件
        }

        private void btnOrderlist_Click(object sender, EventArgs e)
        {
            if (Formlogin.is值日生)
            {
                openChildForm(new FormOrderList());
            }
            else
            {
                MessageBox.Show("您非值日生，無此權限!");
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            if (Formlogin.is管理者)
            {
                openChildForm(new FormAddFood());
            }
            else
            {
                MessageBox.Show("您無此權限!");
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (Formlogin.is管理者)
            {
                openChildForm(new FormClassSetting());
            }
            else
            {
                MessageBox.Show("您無此權限!");
            }
            
        }

        private void btnLog_In_Click(object sender, EventArgs e)
        {
            openChildForm(new Formlogin());           
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFavorite());
        }

        private void btn顯示_Click(object sender, EventArgs e)
        {
            lblUser.Text = $"Hi，{Formlogin.userName}!!";
            lblClass.Text = $"Class:{Formlogin.userClass}.";
            值日生顯示();
            //test
        }
    }
}

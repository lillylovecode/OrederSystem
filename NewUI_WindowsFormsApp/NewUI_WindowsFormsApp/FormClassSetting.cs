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
    public partial class FormClassSetting : Form
    {
        string myDBConnectionString = "";
        int selStuID = 0;
        public FormClassSetting()
        {
            InitializeComponent();
        }

        private void FormClassSetting_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myods";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            產生值日生名單();
        }

        void 產生值日生名單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from student;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable(); //中介物件
                dt.Load(reader);
                dgv值日生.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update student set 值日生=@Status where stuID=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", selStuID);
            cmd.Parameters.AddWithValue("@Status", chk值日生.Checked);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(row + "筆資料已更新");
            產生值日生名單();
        }

        private void dgv值日生_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; } //避免點到欄位會當掉
            string strSelID = dgv值日生.Rows[e.RowIndex].Cells[0].Value.ToString();
            Int32.TryParse(strSelID, out selStuID);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from student where stuID = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", selStuID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtStuID.Text = string.Format("{0}", reader["stuID"]);
                txtstuName.Text = string.Format("{0}", reader["stuName"]);
                chk值日生.Checked = (bool)reader["值日生"];
            }
            reader.Close();
            con.Close();
        }
    }
}

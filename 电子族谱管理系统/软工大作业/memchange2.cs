using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 软工大作业
{
    public partial class memchange2 : Form
    {
        public string memberid2;

        public memchange2()
        {
            InitializeComponent();
        }

        private void confirm1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=无趣中心;Initial Catalog=电子族谱管理系统;Integrated Security=True";

            StringBuilder sb = new StringBuilder();
            sb.Append(@" UPDATE 成员表 SET ");
            
            sb.Append("M_ID='" + textBox1.Text + "',");
            sb.Append("M_sex='" + textBox2.Text + "',");
            sb.Append("TBL_ID='" + textBox3.Text + "',");
            sb.Append("M_birthday='" + textBox4.Text + "',");
            sb.Append("M_death='" + textBox5.Text + "',");
            sb.Append("M_name='" + textBox6.Text + "'");
            sb.Append("FatherID='" + textBox7.Text + "'");
            sb.Append("spousename='" + textBox8.Text + "'");
            sb.Append("M_seniority='" + textBox9.Text + "'");
            sb.Append(" WHERE M_ID = '" + memberid2 + "'");

            string sql = sb.ToString();
            SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            SqlCon.Open(); //打开数据库

            SqlCommand cmd = new SqlCommand(sql, SqlCon);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("成员信息修改完成! ");
             }
            catch (Exception msg)
            {
                MessageBox.Show("出问题了! \n出错原因:" + msg.Message);
            }
        }
    }
}

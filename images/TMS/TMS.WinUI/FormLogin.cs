using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TMS.WinUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            SqlConnection con2 = new SqlConnection(conStr);
            try{
            con.Open();
            con2.Open();
            string query = "Select * from Users where Password ='" + this.textBox1.Text + "' AND UserName='" + this.comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string query2 = "Update Users set isActive='1' where  Password ='" + this.textBox1.Text + "' AND UserName='" + this.comboBox1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con2);
            cmd2.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
                {
                      
                      this.Hide();
                      new FormMain().ShowDialog();
                      this.Close();
                }
              rdr.Close();
             MessageBox.Show("Invalid Password...");
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                if (con2.State == ConnectionState.Open)
                {
                    con2.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = new TMS.BLL.UserBLL().GetAllUsersInTable();
            comboBox1.DisplayMember = "UserName";
        }
    }
}

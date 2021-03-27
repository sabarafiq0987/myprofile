using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TMS.Common;
using TMS.BLL;
namespace TMS.WinUI
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text) || String.IsNullOrEmpty(this.textBox3.Text) || String.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Please Enter Valid Record!!!");
            }
            else
            {
                User user = new User();
                user.FullName = this.textBox1.Text;
                user.Name = this.textBox2.Text;
                user.Password = this.textBox3.Text;
                user.Type = this.comboBox1.Text;
                user.IsActive = this.checkBox2.Text;
                UserBLL ubll = new UserBLL();
                try
                {
                    if (ubll.insertUser(user))
                    {
                        MessageBox.Show("Saved Successfully!!!!!");
                    }
                    else
                    {
                        MessageBox.Show("Failed To Save!!!!");
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDeletionForm del = new UserDeletionForm();
            del.ShowDialog();
            if(del.select)
            { 
                User user=new User();
                user.Password=del.selectedUser1.Password;
                user.Name = del.selectedUser1.Name;
                    UserBLL ubll = new UserBLL();
                    try
                    {
                        if (ubll.delUser(user))
                        {
                            MessageBox.Show("successfully deleted!!!");
                        }
                        else
                        {
                            MessageBox.Show("Unsucessful........ deletion failed!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSearch form= new FormSearch();
            form.ShowDialog();
            if(form.search)
            {
                this.textBox1.Text = form.selectedUser.FullName;
                this.textBox2.Text = form.selectedUser.Name;
                this.textBox3.Text = form.selectedUser.Password;
                this.comboBox1.Text = form.selectedUser.Type;
                if(form.selectedUser.IsActive!=null)
                {
                    this.checkBox2.Checked = true;
                }
                else
                {
                    this.checkBox2.Checked = false;
                }
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().ShowDialog();
            this.Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Common;

namespace TMS.WinUI
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        public User selectedUser;
        public bool search;
        private void button1_Click(object sender, EventArgs e)
        {
             if(dataGridView1.SelectedRows.Count>0)
             {
                 selectedUser = new User();
                 search = true;
                 int index = dataGridView1.SelectedRows[0].Index;
                 selectedUser.FullName = Convert.ToString(dataGridView1.Rows[index].Cells["FullName"].Value);
                 selectedUser.Type = Convert.ToString(dataGridView1.Rows[index].Cells["Type"].Value);
                 selectedUser.IsActive =Convert.ToString(dataGridView1.Rows[index].Cells["IsActive"].Value);
                 selectedUser.Name = Convert.ToString(dataGridView1.Rows[index].Cells["UserName"].Value);
                 selectedUser.Password = Convert.ToString(dataGridView1.Rows[index].Cells["Password"].Value);
                 this.Close();
             }
        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new TMS.BLL.UserBLL().GetAllUsersInTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = false;
            this.Hide();
            new FormUser().ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

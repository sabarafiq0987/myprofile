using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Common;
using System.Data.SqlClient;
namespace TMS.WinUI
{
    public partial class UserDeletionForm : Form
    {
        public UserDeletionForm()
        {
            InitializeComponent();
        }
        public User selectedUser1;
        public bool select = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserDeletionForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new TMS.BLL.UserBLL().GetAllUsersInTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedUser1 = new User();
                select = true;
                int index = dataGridView1.SelectedRows[0].Index;
                selectedUser1.FullName = Convert.ToString(dataGridView1.Rows[index].Cells["FullName"].Value);
                selectedUser1.Type = Convert.ToString(dataGridView1.Rows[index].Cells["Type"].Value);
                selectedUser1.IsActive = Convert.ToString(dataGridView1.Rows[index].Cells["IsActive"].Value);
                selectedUser1.Name = Convert.ToString(dataGridView1.Rows[index].Cells["UserName"].Value);
                selectedUser1.Password = Convert.ToString(dataGridView1.Rows[index].Cells["Password"].Value);
            }
        }
    }
}
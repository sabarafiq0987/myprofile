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
    public partial class CustomerDelete : Form
    {
        public CustomerDelete()
        {
            InitializeComponent();
        }
        public bool select;
        public Customer selectedCustomer1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerDelete_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new TMS.BLL.CustomerBLL().GetAllUsersInTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select = true;
            selectedCustomer1 = new Customer();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                selectedCustomer1.FullName = Convert.ToString(dataGridView1.Rows[index].Cells["FullName"].Value);
                selectedCustomer1.CNIC = Convert.ToString(dataGridView1.Rows[index].Cells["CNIC"].Value);
                selectedCustomer1.Address = Convert.ToString(dataGridView1.Rows[index].Cells["Address"].Value);
                selectedCustomer1.MobileNo = Convert.ToString(dataGridView1.Rows[index].Cells["Mobile No"].Value);
                selectedCustomer1.Remarks = Convert.ToString(dataGridView1.Rows[index].Cells["Remarks"].Value);
                selectedCustomer1.Measurements = Convert.ToString(dataGridView1.Rows[index].Cells["Measurements"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select = false;
        }
    }
}

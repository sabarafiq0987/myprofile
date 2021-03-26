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
    public partial class FormSearchCustomer : Form
    {
        public FormSearchCustomer()
        {
            InitializeComponent();
        }
        public bool search;
        public Customer cust;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormSearchCustomer_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new TMS.BLL.CustomerBLL().GetAllUsersInTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust = new Customer();
            search = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                cust.FullName = Convert.ToString(dataGridView1.Rows[index].Cells["FullName"].Value);
                cust.CNIC = Convert.ToString(dataGridView1.Rows[index].Cells["CNIC"].Value);
                cust.Address = Convert.ToString(dataGridView1.Rows[index].Cells["Address"].Value);
                cust.MobileNo = Convert.ToString(dataGridView1.Rows[index].Cells["Mobile No"].Value);
                cust.Remarks = Convert.ToString(dataGridView1.Rows[index].Cells["Remarks"].Value);
                cust.Measurements = Convert.ToString(dataGridView1.Rows[index].Cells["Measurements"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

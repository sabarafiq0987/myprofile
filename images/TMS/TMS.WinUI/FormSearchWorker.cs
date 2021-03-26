using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.BLL;
using TMS.Common;

namespace TMS.WinUI
{
    public partial class FormSearchWorker : Form
    {
        public FormSearchWorker()
        {
            InitializeComponent();
        }
        public bool select;
        public Worker selectedW;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSearchWorker_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new WorkerBLL().GetAllWorkersInTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select = true;
            selectedW = new Worker();
            if (dataGridView1.SelectedRows.Count > 0)
             {
                int index = dataGridView1.SelectedRows[0].Index;
                selectedW.FullName = Convert.ToString(dataGridView1.Rows[index].Cells["FullName"].Value);
                selectedW.CNIC = Convert.ToString(dataGridView1.Rows[index].Cells["CNIC"].Value);
                selectedW.Address = Convert.ToString(dataGridView1.Rows[index].Cells["Address"].Value);
                selectedW.MobileNo = Convert.ToString(dataGridView1.Rows[index].Cells["Mobile No"].Value);
                selectedW.EmgContact = Convert.ToString(dataGridView1.Rows[index].Cells["EmgContact"].Value);
                selectedW.JoinDate = Convert.ToDateTime(dataGridView1.Rows[index].Cells["JoinDate"].Value);
                selectedW.IsActive = Convert.ToString(dataGridView1.Rows[index].Cells["IsActive"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select = false;
        }
    }
}

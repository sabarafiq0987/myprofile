using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMS.WinUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUser().Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCustomer().Show();
        }

        private void addWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormWorker().Show();
        }

        private void assignWorkToWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAssignWorkToWorker().Show();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

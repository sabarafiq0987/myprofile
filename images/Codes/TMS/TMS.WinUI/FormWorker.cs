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
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text) || String.IsNullOrEmpty(this.textBox3.Text) || String.IsNullOrEmpty(this.textBox4.Text) || String.IsNullOrEmpty(this.comboBox1.Text) || String.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                MessageBox.Show("Please Enter Valid Record!!!");
            }
            else
            {
                try
                {
                 Worker w = new Worker();
                     w.FullName = this.textBox1.Text;
                     w.CNIC = this.textBox2.Text;
                     w.Address = this.textBox3.Text;
                     w.MobileNo = this.textBox4.Text;
                     w.EmgContact = comboBox1.Text;
                     w.JoinDate= Convert.ToDateTime(dateTimePicker1.Value.Date);
                     w.IsActive = this.checkBox2.Text;
                     WorkerBLL wbll = new WorkerBLL();
                    if (wbll.insertWorker(w))
                    {
                        MessageBox.Show("Worker Successfully Added!!!!!");
                    }
                    else
                    {
                        MessageBox.Show("Failed To Add!!!!");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void FormWorker_Load_1(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = new WorkerBLL().GetAllWorkersInTable();
            comboBox1.DisplayMember = "EmgContact";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSearchWorker frm = new FormSearchWorker();
            frm.ShowDialog();
            if(frm.select)
            {
                this.textBox1.Text=frm.selectedW.FullName;
                this.textBox2.Text=frm.selectedW.CNIC;
                this.textBox3.Text=frm.selectedW.Address;
                this.textBox4.Text=frm.selectedW.MobileNo;
                comboBox1.Text=frm.selectedW.EmgContact;
                dateTimePicker1.Value=Convert.ToDateTime(frm.selectedW.JoinDate);
                if (frm.selectedW.IsActive==null)
                {
                    checkBox2.Checked = false;
                }
                else
                {
                     checkBox2.Checked = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSearchWorker w = new FormSearchWorker();
            Worker selectedWorker=new Worker();
            w.ShowDialog();
            if(w.select)
            {
                selectedWorker.FullName=w.selectedW.FullName;
                selectedWorker.CNIC=w.selectedW.CNIC;
                WorkerBLL wb = new WorkerBLL();
                if(wb.delWorker(selectedWorker))
                {
                    MessageBox.Show("Successfully Deleted....");
                }
                else
                {
                    MessageBox.Show("Unsuccessful.....");
                }
            }
        }
    }
}

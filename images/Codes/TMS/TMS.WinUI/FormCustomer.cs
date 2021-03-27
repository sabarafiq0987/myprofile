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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGetMeasurements frm=new FormGetMeasurements();
            frm.ShowDialog();
            if(frm.flag)
            {
                listBox1.Items.Add(frm.c.Measurements);
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text) || String.IsNullOrEmpty(this.textBox3.Text) || String.IsNullOrEmpty(this.textBox4.Text)||String.IsNullOrEmpty(this.textBox5.Text))
            {
                MessageBox.Show("Please Enter Valid Record!!!");
            }
            else
            {
                Customer customer = new Customer();
                customer.FullName = this.textBox1.Text;
                customer.CNIC = this.textBox2.Text;
                customer.Address = this.textBox3.Text;
                customer.MobileNo = this.textBox4.Text;
                customer.Remarks= this.textBox5.Text;
                customer.Measurements =this.listBox1.SelectedItem.ToString();
                CustomerBLL cbll = new CustomerBLL();
                try
                {
                    if (cbll.insertCustomer(customer))
                    {
                        MessageBox.Show("Customer Successfully Added!!!!!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormSearchCustomer form = new FormSearchCustomer();
            form.ShowDialog();
            if (form.search)
            {
                this.textBox1.Text = form.cust.FullName;
                this.textBox2.Text = form.cust.CNIC;
                this.textBox3.Text = form.cust.Address;
                this.textBox4.Text = form.cust.MobileNo;
                this.textBox5.Text = form.cust.Remarks;
                this.listBox1.Items.Add(form.cust.Measurements);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerDelete del = new CustomerDelete();
            del.ShowDialog();
            if (del.select)
            {
                Customer customer= new Customer();
                customer.CNIC = del.selectedCustomer1.CNIC;
                customer.FullName = del.selectedCustomer1.FullName;
                CustomerBLL cbll = new CustomerBLL();
                try
                {
                    if (cbll.delCustomer(customer))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

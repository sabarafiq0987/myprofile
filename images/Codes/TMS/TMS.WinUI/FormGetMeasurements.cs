using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using TMS.Common;

namespace TMS.WinUI
{
    public partial class FormGetMeasurements : Form
    {
        public bool flag = false;
        public Customer c;
        public FormGetMeasurements()
        {
            InitializeComponent();
        }
        private void FormGetMeasurements_Load(object sender, EventArgs e)
        {

            string[] files = Directory.GetFiles(@"C:\Users\Saba Rafique\Documents\Visual Studio 2013\Projects\TMS\TMS\TMS.WinUI\bin\Debug\Measurements");
            foreach (string file in files)
            {
                comboBox1.Items.Add(Path.GetFileName(file));
            }
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = comboBox1.SelectedItem.ToString();
                string[] lineOfContents = File.ReadAllLines(@"C:\Users\Saba Rafique\Documents\Visual Studio 2013\Projects\TMS\TMS\TMS.WinUI\bin\Debug\Measurements\"+this.comboBox1.SelectedItem.ToString()+"");
                foreach (var line in lineOfContents)
                {
                    string[] tokens = line.Split();
                    dataGridView1.Rows.Add(tokens[0]);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c=new Customer();
            flag= true;
            int index = dataGridView1.SelectedRows[0].Index;
            c.Measurements = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value) +" "+Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            this.Close();
        }
    }
}

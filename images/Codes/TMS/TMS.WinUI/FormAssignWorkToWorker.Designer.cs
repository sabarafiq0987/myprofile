namespace TMS.WinUI
{
    partial class FormAssignWorkToWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAssigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOverDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(39, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wokers Detail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 38);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(135, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 95);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Measurement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Worker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price for Work";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(417, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Remarks";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Mark as Complete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColWorkerName,
            this.colTotalAssigned,
            this.colCompleted,
            this.colPending,
            this.colOverDueDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColWorkerName
            // 
            this.ColWorkerName.HeaderText = "Worker Name";
            this.ColWorkerName.Name = "ColWorkerName";
            // 
            // colTotalAssigned
            // 
            this.colTotalAssigned.HeaderText = "Assigned Task";
            this.colTotalAssigned.Name = "colTotalAssigned";
            // 
            // colCompleted
            // 
            this.colCompleted.HeaderText = "Completed";
            this.colCompleted.Name = "colCompleted";
            // 
            // colPending
            // 
            this.colPending.HeaderText = "Remaing/Pending";
            this.colPending.Name = "colPending";
            // 
            // colOverDueDate
            // 
            this.colOverDueDate.HeaderText = "Total Over Due Date";
            this.colOverDueDate.Name = "colOverDueDate";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(276, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMeasurementToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.cancleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 70);
            // 
            // addNewMeasurementToolStripMenuItem
            // 
            this.addNewMeasurementToolStripMenuItem.Name = "addNewMeasurementToolStripMenuItem";
            this.addNewMeasurementToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewMeasurementToolStripMenuItem.Text = "Add New Measurement";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // cancleToolStripMenuItem
            // 
            this.cancleToolStripMenuItem.Name = "cancleToolStripMenuItem";
            this.cancleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cancleToolStripMenuItem.Text = "Cancle";
            // 
            // FormAssignWorkToWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 384);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAssignWorkToWorker";
            this.Text = "Assign Work To worker";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverDueDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancleToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}
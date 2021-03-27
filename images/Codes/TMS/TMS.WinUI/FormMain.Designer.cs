namespace TMS.WinUI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignWorkToWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkWorkStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerDuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.assignmentToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.addWorkerToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // addWorkerToolStripMenuItem
            // 
            this.addWorkerToolStripMenuItem.Name = "addWorkerToolStripMenuItem";
            this.addWorkerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addWorkerToolStripMenuItem.Text = "Add Worker";
            this.addWorkerToolStripMenuItem.Click += new System.EventHandler(this.addWorkerToolStripMenuItem_Click);
            // 
            // assignmentToolStripMenuItem
            // 
            this.assignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignWorkToWorkerToolStripMenuItem,
            this.checkWorkStatusToolStripMenuItem});
            this.assignmentToolStripMenuItem.Name = "assignmentToolStripMenuItem";
            this.assignmentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.assignmentToolStripMenuItem.Text = "Assignment";
            // 
            // assignWorkToWorkerToolStripMenuItem
            // 
            this.assignWorkToWorkerToolStripMenuItem.Name = "assignWorkToWorkerToolStripMenuItem";
            this.assignWorkToWorkerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.assignWorkToWorkerToolStripMenuItem.Text = "Assign Work to Worker";
            this.assignWorkToWorkerToolStripMenuItem.Click += new System.EventHandler(this.assignWorkToWorkerToolStripMenuItem_Click);
            // 
            // checkWorkStatusToolStripMenuItem
            // 
            this.checkWorkStatusToolStripMenuItem.Name = "checkWorkStatusToolStripMenuItem";
            this.checkWorkStatusToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.checkWorkStatusToolStripMenuItem.Text = "Check Work Status";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completedWorkToolStripMenuItem,
            this.pendingWorkToolStripMenuItem,
            this.workerDuesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // completedWorkToolStripMenuItem
            // 
            this.completedWorkToolStripMenuItem.Name = "completedWorkToolStripMenuItem";
            this.completedWorkToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.completedWorkToolStripMenuItem.Text = "Completed Work";
            // 
            // pendingWorkToolStripMenuItem
            // 
            this.pendingWorkToolStripMenuItem.Name = "pendingWorkToolStripMenuItem";
            this.pendingWorkToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pendingWorkToolStripMenuItem.Text = "Pending Work";
            // 
            // workerDuesToolStripMenuItem
            // 
            this.workerDuesToolStripMenuItem.Name = "workerDuesToolStripMenuItem";
            this.workerDuesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.workerDuesToolStripMenuItem.Text = "Worker Dues";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Copy Right 2020";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 288);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignWorkToWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkWorkStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerDuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}
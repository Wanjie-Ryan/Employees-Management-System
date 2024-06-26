﻿namespace Employees_Management_System.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblInactiveEmp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblActiveEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalEmpCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagementSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeManagementSystemToolStripMenuItem
            // 
            this.employeeManagementSystemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.employeeManagementSystemToolStripMenuItem.Name = "employeeManagementSystemToolStripMenuItem";
            this.employeeManagementSystemToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.employeeManagementSystemToolStripMenuItem.Text = "Employee Management System";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1159, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSalary);
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 561);
            this.panel1.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 513);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(153, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnSalary
            // 
            this.btnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalary.Image = ((System.Drawing.Image)(resources.GetObject("btnSalary.Image")));
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(46, 418);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(230, 45);
            this.btnSalary.TabIndex = 7;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(46, 326);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(230, 45);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(46, 234);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(230, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(89, 168);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(131, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Good Afternoon";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(340, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 561);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(804, 318);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Controls.Add(this.lblInactiveEmp);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(547, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 136);
            this.panel5.TabIndex = 1;
            // 
            // lblInactiveEmp
            // 
            this.lblInactiveEmp.AutoSize = true;
            this.lblInactiveEmp.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInactiveEmp.Location = new System.Drawing.Point(171, 18);
            this.lblInactiveEmp.Name = "lblInactiveEmp";
            this.lblInactiveEmp.Size = new System.Drawing.Size(65, 32);
            this.lblInactiveEmp.TabIndex = 6;
            this.lblInactiveEmp.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inactive Employees";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 84);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.lblActiveEmp);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(281, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 136);
            this.panel4.TabIndex = 1;
            // 
            // lblActiveEmp
            // 
            this.lblActiveEmp.AutoSize = true;
            this.lblActiveEmp.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActiveEmp.Location = new System.Drawing.Point(167, 18);
            this.lblActiveEmp.Name = "lblActiveEmp";
            this.lblActiveEmp.Size = new System.Drawing.Size(65, 32);
            this.lblActiveEmp.TabIndex = 3;
            this.lblActiveEmp.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Active Employees";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 84);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.lblTotalEmpCount);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(17, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 136);
            this.panel3.TabIndex = 0;
            // 
            // lblTotalEmpCount
            // 
            this.lblTotalEmpCount.AutoSize = true;
            this.lblTotalEmpCount.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmpCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalEmpCount.Location = new System.Drawing.Point(156, 18);
            this.lblTotalEmpCount.Name = "lblTotalEmpCount";
            this.lblTotalEmpCount.Size = new System.Drawing.Size(65, 32);
            this.lblTotalEmpCount.TabIndex = 2;
            this.lblTotalEmpCount.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Employees";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementSystemToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblInactiveEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblActiveEmp;
        private System.Windows.Forms.Label lblTotalEmpCount;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
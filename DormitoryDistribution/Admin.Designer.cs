﻿namespace DormitoryDistribution
{
    partial class Admin
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
            this.OpenViewAlUsersForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHostelAllocationForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenViewAlUsersForm
            // 
            this.OpenViewAlUsersForm.Location = new System.Drawing.Point(169, 51);
            this.OpenViewAlUsersForm.Name = "OpenViewAlUsersForm";
            this.OpenViewAlUsersForm.Size = new System.Drawing.Size(152, 42);
            this.OpenViewAlUsersForm.TabIndex = 0;
            this.OpenViewAlUsersForm.Text = "View All Users";
            this.OpenViewAlUsersForm.UseVisualStyleBackColor = true;
            this.OpenViewAlUsersForm.Click += new System.EventHandler(this.OpenViewAlUsersForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // OpenHostelAllocationForm
            // 
            this.OpenHostelAllocationForm.Location = new System.Drawing.Point(169, 99);
            this.OpenHostelAllocationForm.Name = "OpenHostelAllocationForm";
            this.OpenHostelAllocationForm.Size = new System.Drawing.Size(152, 46);
            this.OpenHostelAllocationForm.TabIndex = 2;
            this.OpenHostelAllocationForm.Text = "Hostel allocation";
            this.OpenHostelAllocationForm.UseVisualStyleBackColor = true;
            this.OpenHostelAllocationForm.Click += new System.EventHandler(this.OpenHostelAllocationForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome ......";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenHostelAllocationForm);
            this.Controls.Add(this.OpenViewAlUsersForm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenViewAlUsersForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button OpenHostelAllocationForm;
        private System.Windows.Forms.Label label1;
    }
}
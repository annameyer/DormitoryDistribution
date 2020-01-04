namespace DormitoryDistribution
{
    partial class User
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
            this.HostelDataGridView = new System.Windows.Forms.DataGridView();
            this.AccommodationAtTheHostel = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearSalaryButton = new System.Windows.Forms.Button();
            this.minSalaryTextBox = new System.Windows.Forms.TextBox();
            this.accommodationAtTheHostelToolStripMenuItemButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.IncomeRadioButton = new System.Windows.Forms.RadioButton();
            this.AverageMarkRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstNameRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataGridView)).BeginInit();
            this.AccommodationAtTheHostel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostelDataGridView
            // 
            this.HostelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostelDataGridView.Location = new System.Drawing.Point(12, 27);
            this.HostelDataGridView.Name = "HostelDataGridView";
            this.HostelDataGridView.ReadOnly = true;
            this.HostelDataGridView.Size = new System.Drawing.Size(844, 411);
            this.HostelDataGridView.TabIndex = 13;
            // 
            // AccommodationAtTheHostel
            // 
            this.AccommodationAtTheHostel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.AccommodationAtTheHostel.Location = new System.Drawing.Point(0, 0);
            this.AccommodationAtTheHostel.Name = "AccommodationAtTheHostel";
            this.AccommodationAtTheHostel.Size = new System.Drawing.Size(1228, 24);
            this.AccommodationAtTheHostel.TabIndex = 27;
            this.AccommodationAtTheHostel.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Back";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.saveToolStripMenuItem.Text = "Export to excel";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ClearSalaryButton
            // 
            this.ClearSalaryButton.Location = new System.Drawing.Point(1107, 262);
            this.ClearSalaryButton.Name = "ClearSalaryButton";
            this.ClearSalaryButton.Size = new System.Drawing.Size(86, 27);
            this.ClearSalaryButton.TabIndex = 33;
            this.ClearSalaryButton.Text = "Clear";
            this.ClearSalaryButton.UseVisualStyleBackColor = true;
            this.ClearSalaryButton.Click += new System.EventHandler(this.ClearSalaryButton_Click);
            // 
            // minSalaryTextBox
            // 
            this.minSalaryTextBox.Location = new System.Drawing.Point(888, 236);
            this.minSalaryTextBox.Name = "minSalaryTextBox";
            this.minSalaryTextBox.Size = new System.Drawing.Size(307, 20);
            this.minSalaryTextBox.TabIndex = 32;
            this.minSalaryTextBox.TextChanged += new System.EventHandler(this.minSalaryTextBox_TextChanged);
            this.minSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minSalaryTextBox_KeyPress);
            // 
            // accommodationAtTheHostelToolStripMenuItemButton
            // 
            this.accommodationAtTheHostelToolStripMenuItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accommodationAtTheHostelToolStripMenuItemButton.Location = new System.Drawing.Point(892, 262);
            this.accommodationAtTheHostelToolStripMenuItemButton.Name = "accommodationAtTheHostelToolStripMenuItemButton";
            this.accommodationAtTheHostelToolStripMenuItemButton.Size = new System.Drawing.Size(202, 27);
            this.accommodationAtTheHostelToolStripMenuItemButton.TabIndex = 31;
            this.accommodationAtTheHostelToolStripMenuItemButton.Text = "Accommodation at the hostel";
            this.accommodationAtTheHostelToolStripMenuItemButton.UseVisualStyleBackColor = true;
            this.accommodationAtTheHostelToolStripMenuItemButton.Click += new System.EventHandler(this.accommodationAtTheHostelToolStripMenuItemButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.SortButton);
            this.groupBox2.Controls.Add(this.IncomeRadioButton);
            this.groupBox2.Controls.Add(this.AverageMarkRadioButton);
            this.groupBox2.Controls.Add(this.GroupRadioButton);
            this.groupBox2.Controls.Add(this.LastNameRadioButton);
            this.groupBox2.Controls.Add(this.FirstNameRadioButton);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(880, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 180);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search and sort";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(244, 34);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 23);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(171, 137);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 23);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(63, 137);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(86, 23);
            this.SortButton.TabIndex = 24;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // IncomeRadioButton
            // 
            this.IncomeRadioButton.AutoSize = true;
            this.IncomeRadioButton.Location = new System.Drawing.Point(227, 72);
            this.IncomeRadioButton.Name = "IncomeRadioButton";
            this.IncomeRadioButton.Size = new System.Drawing.Size(70, 20);
            this.IncomeRadioButton.TabIndex = 23;
            this.IncomeRadioButton.TabStop = true;
            this.IncomeRadioButton.Text = "Income";
            this.IncomeRadioButton.UseVisualStyleBackColor = true;
            this.IncomeRadioButton.CheckedChanged += new System.EventHandler(this.IncomeRadioButton_CheckedChanged);
            // 
            // AverageMarkRadioButton
            // 
            this.AverageMarkRadioButton.AutoSize = true;
            this.AverageMarkRadioButton.Location = new System.Drawing.Point(120, 98);
            this.AverageMarkRadioButton.Name = "AverageMarkRadioButton";
            this.AverageMarkRadioButton.Size = new System.Drawing.Size(111, 20);
            this.AverageMarkRadioButton.TabIndex = 22;
            this.AverageMarkRadioButton.TabStop = true;
            this.AverageMarkRadioButton.Text = "Average mark";
            this.AverageMarkRadioButton.UseVisualStyleBackColor = true;
            this.AverageMarkRadioButton.CheckedChanged += new System.EventHandler(this.AverageMarkRadioButton_CheckedChanged);
            // 
            // GroupRadioButton
            // 
            this.GroupRadioButton.AutoSize = true;
            this.GroupRadioButton.Location = new System.Drawing.Point(120, 72);
            this.GroupRadioButton.Name = "GroupRadioButton";
            this.GroupRadioButton.Size = new System.Drawing.Size(63, 20);
            this.GroupRadioButton.TabIndex = 21;
            this.GroupRadioButton.TabStop = true;
            this.GroupRadioButton.Text = "Group";
            this.GroupRadioButton.UseVisualStyleBackColor = true;
            this.GroupRadioButton.CheckedChanged += new System.EventHandler(this.GroupRadioButton_CheckedChanged);
            // 
            // LastNameRadioButton
            // 
            this.LastNameRadioButton.AutoSize = true;
            this.LastNameRadioButton.Location = new System.Drawing.Point(12, 98);
            this.LastNameRadioButton.Name = "LastNameRadioButton";
            this.LastNameRadioButton.Size = new System.Drawing.Size(94, 20);
            this.LastNameRadioButton.TabIndex = 20;
            this.LastNameRadioButton.TabStop = true;
            this.LastNameRadioButton.Text = "Last Name ";
            this.LastNameRadioButton.UseVisualStyleBackColor = true;
            this.LastNameRadioButton.CheckedChanged += new System.EventHandler(this.LastNameRadioButton_CheckedChanged);
            // 
            // FirstNameRadioButton
            // 
            this.FirstNameRadioButton.AutoSize = true;
            this.FirstNameRadioButton.Location = new System.Drawing.Point(12, 72);
            this.FirstNameRadioButton.Name = "FirstNameRadioButton";
            this.FirstNameRadioButton.Size = new System.Drawing.Size(91, 20);
            this.FirstNameRadioButton.TabIndex = 19;
            this.FirstNameRadioButton.TabStop = true;
            this.FirstNameRadioButton.Text = "First Name";
            this.FirstNameRadioButton.UseVisualStyleBackColor = true;
            this.FirstNameRadioButton.CheckedChanged += new System.EventHandler(this.FirstNameRadioButton_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 34);
            this.SearchTextBox.MaxLength = 20;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(227, 22);
            this.SearchTextBox.TabIndex = 17;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 587);
            this.Controls.Add(this.AccommodationAtTheHostel);
            this.Controls.Add(this.ClearSalaryButton);
            this.Controls.Add(this.minSalaryTextBox);
            this.Controls.Add(this.accommodationAtTheHostelToolStripMenuItemButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.HostelDataGridView);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accommodation at the hostel";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataGridView)).EndInit();
            this.AccommodationAtTheHostel.ResumeLayout(false);
            this.AccommodationAtTheHostel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView HostelDataGridView;
        private System.Windows.Forms.MenuStrip AccommodationAtTheHostel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button ClearSalaryButton;
        private System.Windows.Forms.TextBox minSalaryTextBox;
        private System.Windows.Forms.Button accommodationAtTheHostelToolStripMenuItemButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.RadioButton IncomeRadioButton;
        private System.Windows.Forms.RadioButton AverageMarkRadioButton;
        private System.Windows.Forms.RadioButton GroupRadioButton;
        private System.Windows.Forms.RadioButton LastNameRadioButton;
        private System.Windows.Forms.RadioButton FirstNameRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}
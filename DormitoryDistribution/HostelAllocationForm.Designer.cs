namespace DormitoryDistribution
{
    partial class HostelAllocationForm
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
            this.AccommodationAtTheHostel = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AverageMarkTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.HiddenIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivitiesCheckBox = new System.Windows.Forms.CheckBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.HostelDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.IncomeRadioButton = new System.Windows.Forms.RadioButton();
            this.AverageMarkRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstNameRadioButton = new System.Windows.Forms.RadioButton();
            this.accommodationAtTheHostelToolStripMenuItemButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.minSalaryTextBox = new System.Windows.Forms.TextBox();
            this.ClearSalaryButton = new System.Windows.Forms.Button();
            this.AccommodationAtTheHostel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccommodationAtTheHostel
            // 
            this.AccommodationAtTheHostel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.AccommodationAtTheHostel.Location = new System.Drawing.Point(0, 0);
            this.AccommodationAtTheHostel.Name = "AccommodationAtTheHostel";
            this.AccommodationAtTheHostel.Size = new System.Drawing.Size(1228, 24);
            this.AccommodationAtTheHostel.TabIndex = 0;
            this.AccommodationAtTheHostel.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.saveToolStripMenuItem.Text = "Import to excel";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(210, 238);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(129, 238);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(48, 238);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(75, 23);
            this.CreateNewButton.TabIndex = 14;
            this.CreateNewButton.Text = "Create new";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.IncomeTextBox);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.CreateNewButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AverageMarkTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GroupTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PatronymicTextBox);
            this.groupBox1.Controls.Add(this.HiddenIdTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ActivitiesCheckBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(880, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 285);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Income";
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(120, 167);
            this.IncomeTextBox.MaxLength = 10;
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.Size = new System.Drawing.Size(197, 22);
            this.IncomeTextBox.TabIndex = 19;
            this.IncomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncomeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Average \r\nmark";
            // 
            // AverageMarkTextBox
            // 
            this.AverageMarkTextBox.Location = new System.Drawing.Point(120, 139);
            this.AverageMarkTextBox.MaxLength = 4;
            this.AverageMarkTextBox.Name = "AverageMarkTextBox";
            this.AverageMarkTextBox.Size = new System.Drawing.Size(197, 22);
            this.AverageMarkTextBox.TabIndex = 17;
            this.AverageMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AverageMarkTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Group";
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(120, 111);
            this.GroupTextBox.MaxLength = 6;
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(197, 22);
            this.GroupTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Patronymic";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(120, 83);
            this.PatronymicTextBox.MaxLength = 10;
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(197, 22);
            this.PatronymicTextBox.TabIndex = 13;
            // 
            // HiddenIdTextBox
            // 
            this.HiddenIdTextBox.Location = new System.Drawing.Point(9, 27);
            this.HiddenIdTextBox.Name = "HiddenIdTextBox";
            this.HiddenIdTextBox.Size = new System.Drawing.Size(19, 22);
            this.HiddenIdTextBox.TabIndex = 12;
            this.HiddenIdTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // ActivitiesCheckBox
            // 
            this.ActivitiesCheckBox.AutoSize = true;
            this.ActivitiesCheckBox.Location = new System.Drawing.Point(120, 203);
            this.ActivitiesCheckBox.Name = "ActivitiesCheckBox";
            this.ActivitiesCheckBox.Size = new System.Drawing.Size(119, 20);
            this.ActivitiesCheckBox.TabIndex = 9;
            this.ActivitiesCheckBox.Text = "Public activities";
            this.ActivitiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(120, 55);
            this.LastNameTextBox.MaxLength = 10;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(120, 27);
            this.FirstNameTextBox.MaxLength = 10;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.FirstNameTextBox.TabIndex = 7;
            // 
            // HostelDataGridView
            // 
            this.HostelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostelDataGridView.Location = new System.Drawing.Point(12, 27);
            this.HostelDataGridView.Name = "HostelDataGridView";
            this.HostelDataGridView.ReadOnly = true;
            this.HostelDataGridView.Size = new System.Drawing.Size(844, 550);
            this.HostelDataGridView.TabIndex = 12;
            this.HostelDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HostelDataGridView_CellClick);
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
            this.groupBox2.Location = new System.Drawing.Point(880, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 180);
            this.groupBox2.TabIndex = 19;
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
            // accommodationAtTheHostelToolStripMenuItemButton
            // 
            this.accommodationAtTheHostelToolStripMenuItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accommodationAtTheHostelToolStripMenuItemButton.Location = new System.Drawing.Point(892, 257);
            this.accommodationAtTheHostelToolStripMenuItemButton.Name = "accommodationAtTheHostelToolStripMenuItemButton";
            this.accommodationAtTheHostelToolStripMenuItemButton.Size = new System.Drawing.Size(202, 27);
            this.accommodationAtTheHostelToolStripMenuItemButton.TabIndex = 20;
            this.accommodationAtTheHostelToolStripMenuItemButton.Text = "Accommodation at the hostel";
            this.accommodationAtTheHostelToolStripMenuItemButton.UseVisualStyleBackColor = true;
            this.accommodationAtTheHostelToolStripMenuItemButton.Click += new System.EventHandler(this.accommodationAtTheHostelToolStripMenuItemButton_Click);
            // 
            // minSalaryTextBox
            // 
            this.minSalaryTextBox.Location = new System.Drawing.Point(888, 231);
            this.minSalaryTextBox.Name = "minSalaryTextBox";
            this.minSalaryTextBox.Size = new System.Drawing.Size(307, 20);
            this.minSalaryTextBox.TabIndex = 21;
            this.minSalaryTextBox.TextChanged += new System.EventHandler(this.minSalaryTextBox_TextChanged);
            this.minSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minSalaryTextBox_KeyPress);
            // 
            // ClearSalaryButton
            // 
            this.ClearSalaryButton.Location = new System.Drawing.Point(1107, 257);
            this.ClearSalaryButton.Name = "ClearSalaryButton";
            this.ClearSalaryButton.Size = new System.Drawing.Size(86, 27);
            this.ClearSalaryButton.TabIndex = 26;
            this.ClearSalaryButton.Text = "Clear";
            this.ClearSalaryButton.UseVisualStyleBackColor = true;
            this.ClearSalaryButton.Click += new System.EventHandler(this.ClearSalaryButton_Click);
            // 
            // HostelAllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 587);
            this.Controls.Add(this.ClearSalaryButton);
            this.Controls.Add(this.minSalaryTextBox);
            this.Controls.Add(this.accommodationAtTheHostelToolStripMenuItemButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HostelDataGridView);
            this.Controls.Add(this.AccommodationAtTheHostel);
            this.MainMenuStrip = this.AccommodationAtTheHostel;
            this.Name = "HostelAllocationForm";
            this.Text = "HostelAllocationForm";
            this.Load += new System.EventHandler(this.HostelAllocationForm_Load);
            this.AccommodationAtTheHostel.ResumeLayout(false);
            this.AccommodationAtTheHostel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AccommodationAtTheHostel;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AverageMarkTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox HiddenIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ActivitiesCheckBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.DataGridView HostelDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton IncomeRadioButton;
        private System.Windows.Forms.RadioButton AverageMarkRadioButton;
        private System.Windows.Forms.RadioButton GroupRadioButton;
        private System.Windows.Forms.RadioButton LastNameRadioButton;
        private System.Windows.Forms.RadioButton FirstNameRadioButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button accommodationAtTheHostelToolStripMenuItemButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox minSalaryTextBox;
        private System.Windows.Forms.Button ClearSalaryButton;
    }
}
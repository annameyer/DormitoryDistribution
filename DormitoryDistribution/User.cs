using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms.OpenAuthorizationForm(this);
        }

        private void User_Load(object sender, EventArgs e)
        {
            ClearControls();
            ClearMinSum();
            LoadGridData();
        }

        private void LoadGridData()
        {
            BindingSource binding = new BindingSource
            {
                DataSource = HostelRepository.GetHostels()
            };

            HostelDataGridView.DataSource = binding;
        }

        private void IsNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            HostelRepository.Search = SearchTextBox.Text.Trim();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void FirstNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HostelRepository.FirstNameChecked = FirstNameRadioButton.Checked;
        }

        private void GroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HostelRepository.GroupNameChecked = GroupRadioButton.Checked;
        }

        private void IncomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HostelRepository.IncomeChecked = IncomeRadioButton.Checked;
        }

        private void LastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HostelRepository.LastNameChecked = LastNameRadioButton.Checked;
        }

        private void AverageMarkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HostelRepository.AverageMarkChecked = AverageMarkRadioButton.Checked;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            HostelRepository.Sort = true;
            LoadGridData();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        public void ClearControls()
        {
            LastNameRadioButton.Checked = false;
            FirstNameRadioButton.Checked = false;
            GroupRadioButton.Checked = false;
            AverageMarkRadioButton.Checked = false;
            IncomeRadioButton.Checked = false;
            SearchTextBox.Text = string.Empty;
            HostelRepository.Sort = true;
            LoadGridData();
        }

        private void minSalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (minSalaryTextBox.Text != string.Empty)
            {
                HostelRepository.MinSalary = decimal.Parse(minSalaryTextBox.Text.Trim());
            }
        }

        private void minSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumber(sender, e);
        }

        private void accommodationAtTheHostelToolStripMenuItemButton_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void ClearSalaryButton_Click(object sender, EventArgs e)
        {
            ClearMinSum();
        }

        private void ClearMinSum()
        {
            HostelRepository.MinSalary = 0;
            minSalaryTextBox.Text = string.Empty;
            LoadGridData();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            string path = "Hostel.hls";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Excel 97-2003 WorkBook|*.xls",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    path = Path.GetFullPath(saveFileDialog1.FileName);

                    myStream.Close();
                }
            }

            DataSet ds = GenerateExcel.GenerateExcelFile(HostelRepository.GetHostels());
            ExcelLibrary.DataSetHelper.CreateWorkbook(path, ds);
            MessageBox.Show("File created successfully");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Help.docx");
        }
    }
}

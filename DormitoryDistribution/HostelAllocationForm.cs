using DormitoryDistribution.DB;
using System;
using System.Windows.Forms;
namespace DormitoryDistribution
{
    public partial class HostelAllocationForm : Form
    {
        public HostelAllocationForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms.OpenAdminForm(this);
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            HiddenIdTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            FirstNameTextBox.Text = string.Empty;
            PatronymicTextBox.Text = string.Empty;
            GroupTextBox.Text = string.Empty;
            AverageMarkTextBox.Text = string.Empty;
            IncomeTextBox.Text = string.Empty;
            ActivitiesCheckBox.Checked = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isOldUser = HiddenIdTextBox.Text.Trim() != string.Empty;
            if (isOldUser)
            {
                UpdateUsers();
                LoadGridData();
                ClearData();
            }
            else
            {
                CreateUsers();
            }
            //else
            //{
            //    MessageBox.Show("Please, enter all data in field");
            //}
        }

        private void UpdateUsers()
        {
            Hostel hostel = new Hostel
            {
                Id = int.Parse(HiddenIdTextBox.Text),
                LastName = LastNameTextBox.Text.Trim(),
                FirstName = FirstNameTextBox.Text.Trim(),
                Patronymic = PatronymicTextBox.Text.Trim(),
                Group = GroupTextBox.Text.Trim(),
                AverageMark = double.Parse(AverageMarkTextBox.Text),
                Income = decimal.Parse(IncomeTextBox.Text),
                Activities = ActivitiesCheckBox.Checked
            };

            HostelRepository.UpdateHostels(hostel);
            MessageBox.Show("Data update successfule!");
        }

        private void CreateUsers()
        {
            Hostel hostel = new Hostel
            {
                LastName = LastNameTextBox.Text.Trim(),
                FirstName = FirstNameTextBox.Text.Trim(),
                Patronymic = PatronymicTextBox.Text.Trim(),
                Group = GroupTextBox.Text.Trim(),
                AverageMark = double.Parse(AverageMarkTextBox.Text),
                Income = decimal.Parse(IncomeTextBox.Text),
                Activities = ActivitiesCheckBox.Checked
            };

            HostelRepository.CreateHostels(hostel);
            MessageBox.Show("Data save successfule!");
            LoadGridData();
            ClearData();
        }

        private void LoadGridData()
        {
            BindingSource binding = new BindingSource
            {
                DataSource = HostelRepository.GetHostels()
            };

            HostelDataGridView.DataSource = binding;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                HostelRepository.DeleteHostels(GetSelectedRecord());
                LoadGridData();
                ClearData();
                MessageBox.Show("Data delete successfule!");
            }
            catch
            {
                MessageBox.Show("Please, select cell for deleting");
            }
        }

        private Hostel GetSelectedRecord()
        {
            return new Hostel
            {
                Id = (int)HostelDataGridView.CurrentRow.Cells[0].Value,
                LastName = HostelDataGridView.CurrentRow.Cells[1].Value.ToString(),
                FirstName = HostelDataGridView.CurrentRow.Cells[2].Value.ToString(),
                Patronymic = HostelDataGridView.CurrentRow.Cells[3].Value.ToString(),
                Group = HostelDataGridView.CurrentRow.Cells[4].Value.ToString(),
                AverageMark = (double)HostelDataGridView.CurrentRow.Cells[5].Value,
                Income = (decimal)HostelDataGridView.CurrentRow.Cells[7].Value,
                Activities = (bool)HostelDataGridView.CurrentRow.Cells[6].Value,
            };
        }

        private void HostelAllocationForm_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void HostelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hostel selectedRecord = GetSelectedRecord();
                HiddenIdTextBox.Text = selectedRecord.Id.ToString();
                LastNameTextBox.Text = selectedRecord.LastName;
                FirstNameTextBox.Text = selectedRecord.FirstName;
                PatronymicTextBox.Text = selectedRecord.Patronymic;
                GroupTextBox.Text = selectedRecord.Group;
                AverageMarkTextBox.Text = selectedRecord.AverageMark.ToString();
                IncomeTextBox.Text = selectedRecord.Income.ToString();
                ActivitiesCheckBox.Checked = selectedRecord.Activities;
            }
            catch (Exception)
            {
                ClearData();

            }
        }

        private void IncomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AverageMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

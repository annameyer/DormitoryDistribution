using DormitoryDistribution.DB;
using System;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class ViewAlUsersForm : Form
    {
        public ViewAlUsersForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms.OpenAdminForm(this);
        }

        private void ViewAlUsersForm_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Users currentUser = GetSelectedUser();
                HiddenIdTextBox.Text = currentUser.Id.ToString();
                LoginTextBox.Text = currentUser.Login;
                PasswordTextBox.Text = currentUser.Password;
                IsAdminCheckBox.Checked = currentUser.IsAdmin;
            }
            catch
            {
                ClearData();

            }
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool modelIsValid = LoginTextBox.Text.Trim() != string.Empty && PasswordTextBox.Text.Trim() != string.Empty;
            bool isOldUser = HiddenIdTextBox.Text.Trim() != string.Empty;
            if (isOldUser)
            {
                UpdateUsers();
                LoadGridData();
                ClearData();
            }
            else if (modelIsValid)
            {
                CreateUsers();                             
            }
            else
            {
                MessageBox.Show("Please, enter all field");
            }            
        }

        private void UpdateUsers()
        {
            Users user = new Users
            {
                Id = int.Parse(HiddenIdTextBox.Text),
                Login = LoginTextBox.Text.Trim(),
                Password = PasswordTextBox.Text.Trim(),
                IsAdmin = IsAdminCheckBox.Checked
            };

            UserRepository.UpdateUsers(user);
            MessageBox.Show("Data updated successfully!");
        }

        private void CreateUsers()
        {
            Users user = new Users
            {
                Login = LoginTextBox.Text.Trim(),
                Password = PasswordTextBox.Text.Trim(),
                IsAdmin = IsAdminCheckBox.Checked
            };

            if (UserRepository.FindUser(user.Login, user.Password) == null)
            {
                UserRepository.CreateUsers(user);
                MessageBox.Show("Data saved successfully!");
                LoadGridData();
                ClearData();
            }
            else
            {
                MessageBox.Show("User exist!");
            }
        }

        private void LoadGridData()
        {
            BindingSource binding = new BindingSource
            {
                DataSource = UserRepository.GetUsers()
            };

            UsersDataGridView.DataSource = binding;
        }

        private void ClearData()
        {
            HiddenIdTextBox.Text = string.Empty;
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            IsAdminCheckBox.Checked = false;
        }

        private Users GetSelectedUser()
        {
            return new Users
            {
                Id = (int)UsersDataGridView.CurrentRow.Cells[0].Value,
                Login = UsersDataGridView.CurrentRow.Cells[1].Value.ToString(),
                Password = UsersDataGridView.CurrentRow.Cells[2].Value.ToString(),
                IsAdmin = (bool)UsersDataGridView.CurrentRow.Cells[3].Value
            };
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item ??",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    UserRepository.DeleteUsers(GetSelectedUser());
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Data deleted successfully!");
                }               
            }
            catch
            {
                MessageBox.Show("Please, select cell for deleting");
            }

        }
    }
}

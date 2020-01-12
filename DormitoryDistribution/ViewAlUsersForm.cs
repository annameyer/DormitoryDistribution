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
            OpenForms.OpenAdminForm(this, true);
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
            }
            else if (modelIsValid)
            {
                CreateUsers();                             
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
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

            if (UserRepository.FindUser(user.Login, user.Password) == null)
            {
                UserRepository.UpdateUsers(user);
                MessageBox.Show("Данные обновлены упешно!");
                LoadGridData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Пользователь существует!");
            }           
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
                MessageBox.Show("Данные сохранены успешно!");
                LoadGridData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Пользователь существует!");
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
                var confirmResult = MessageBox.Show("Вы действительно хотите удалить?",
                                     "Подтверждение удаления",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    UserRepository.DeleteUsers(GetSelectedUser());
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Данные удалены успешно!");
                }               
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберете строку для удаления");
            }

        }
    }
}

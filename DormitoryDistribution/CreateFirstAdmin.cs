using DormitoryDistribution.DB;
using System;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class CreateFirstAdmin : Form
    {
        public CreateFirstAdmin()
        {
            InitializeComponent();
        }

        private void CreateAdminButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            Users admin = new Users
            {
                Login = login,
                Password = password,
                IsAdmin = true
            };
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                UserRepository.CreateUsers(admin);
                OpenForms.OpenAdminForm(this, true);
            }
            else
            {
                    ErrorLabel.Text = "Enter login or password";
            }
        }
    }
}

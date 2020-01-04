//using DormitoryDistribution.DB;
using System;
//using System.Linq;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            var login = LoginTextBox.Text.Trim();
            var password = PasswordTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                var user = UserRepository.FindUser(login, password);
                if (user != null)
                {
                    if (user.IsAdmin)
                    {
                        OpenForms.OpenAdminForm(this);
                    }
                    else
                    {
                        OpenForms.OpenUserForm(this);
                    }
                }
                else
                {
                    ErrorLabel.Text = "Password or login not correct";
                }
            }
            else
            {
                if (UserRepository.IsFirstUser())
                {
                    OpenForms.OpenCreateFirstAdminForm(this);
                }
                else
                {
                    ErrorLabel.Text = "Enter login or password";
                }
            }
        }             

        private void viewPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(viewPasswordCheck.Checked){
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}

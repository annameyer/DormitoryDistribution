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
            //using (DormitoryDistributionContext _context = new DormitoryDistributionContext())
            //{
                //ErrorLabel.Text = "";
                //var login = LoginTextBox.Text.Trim();
                //var password = PasswordTextBox.Text.Trim();

                //if(!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
                //{
                //    var user = _context.Authorizations.FirstOrDefault(x => x.Login == login && x.Password == password);
                //    if(user != null)
                //    {
                //        if (user.IsAdmin) {
                            OpenForms.OpenAdminForm(this);
                //        }
                //        else
                //        {
                //            OpenForms.OpenUserForm(this);
                //        }
                //    }
                //    else
                //    {
                //        ErrorLabel.Text = "Password or login not correct";
                //    }
                //}
                //else
                //{
                //    if (_context.Authorizations.Count() == 0)
                //    {
                //        OpenForms.OpenCreateFirstAdminForm(this);
                //    }
                //    else
                //    {
                //        ErrorLabel.Text = "Enter login or password";
                //    }
                //}
            //}
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

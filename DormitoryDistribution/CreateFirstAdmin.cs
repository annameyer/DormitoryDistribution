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
            using (DormitoryDistributionContext _context = new DormitoryDistributionContext())
            {
                var login = LoginTextBox.Text.Trim();
                var password = PasswordTextBox.Text.Trim();
                var admin = new Authorization
                {
                    Login = login,
                    Password = password,
                    IsAdmin = true
                };
                _context.Authorizations.Add(admin);
                _context.SaveChanges();
                var loginForm = new AuthorizationForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}

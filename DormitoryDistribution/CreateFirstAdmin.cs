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
                var admin = new Users
                {
                    Login = login,
                    Password = password,
                    IsAdmin = true
                };
                _context.Users.Add(admin);
                _context.SaveChanges();
                OpenForms.OpenAuthorizationForm(this);
            }
        }
    }
}

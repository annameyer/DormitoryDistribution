using DormitoryDistribution.DB;
using System;
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
            using (DormitoryDistributionContext _context = new DormitoryDistributionContext())
            {
                var user = _context.Authorizations;
                _context.SaveChanges();
                var per = PasswordTextBox.Text;
                var per2 = LoginTextBox;
            }
        }
    }
}

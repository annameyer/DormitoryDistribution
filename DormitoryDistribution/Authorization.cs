using DormitoryDistribution.DB;
using System;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (DormitoryDistributionContext _context = new DormitoryDistributionContext())
            {
                var user = _context.Authorizations;
                var per = PasswordTextBox.Text;
                var per2 = LoginTextBox;
            }
        }
    }
}

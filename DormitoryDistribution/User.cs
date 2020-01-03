using System;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms.OpenAuthorizationForm(this);
        }
    }
}

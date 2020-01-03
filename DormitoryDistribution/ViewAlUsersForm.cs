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
    }
}

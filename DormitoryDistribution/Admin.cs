using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void OpenViewAlUsersForm_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenViewAlUsersForm(this);
        }

        private void OpenHostelAllocationForm_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenHostelAllocationForm(this);
        }

        private void helpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenAuthorizationForm(this);
        }
    }
}

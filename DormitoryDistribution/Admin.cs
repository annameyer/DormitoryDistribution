using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class Admin : Form
    {
        private bool IsAdmin;
        public Admin(bool isAdmin)
        {
            IsAdmin = isAdmin;
            InitializeComponent();
        }

        private void OpenViewAlUsersForm_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenViewAlUsersForm(this);
        }

        private void OpenHostelAllocationForm_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenHostelAllocationForm(this, IsAdmin);
        }

        private void helpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenAuthorizationForm(this);
        }

        private void helpToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("HelpAdmin.docx");
        }
    }
}

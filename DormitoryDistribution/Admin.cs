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
    }
}

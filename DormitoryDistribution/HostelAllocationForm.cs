using System;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class HostelAllocationForm : Form
    {
        public HostelAllocationForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms.OpenAdminForm(this);
        }
    }
}

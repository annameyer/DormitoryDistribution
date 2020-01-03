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

        private void User_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void LoadGridData()
        {
            BindingSource binding = new BindingSource
            {
                DataSource = HostelRepository.GetHostels()
            };

            HostelDataGridView.DataSource = binding;
        }
    }
}

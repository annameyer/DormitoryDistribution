using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            OpenForms.OpenAuthorizationForm(this);
        }
    }
}

using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class MinSalaryPopUp : Form
    {
        public MinSalaryPopUp()
        {
            InitializeComponent();
        }

        private void MinSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

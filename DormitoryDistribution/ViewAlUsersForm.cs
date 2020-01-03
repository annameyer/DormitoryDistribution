using DormitoryDistribution.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DormitoryDistribution
{
    public partial class ViewAlUsersForm : Form
    {
        private List<Authorization> _users = new List<Authorization>();

        public ViewAlUsersForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms.OpenAdminForm(this);
        }

        private void ViewAlUsersForm_Load(object sender, EventArgs e)
        {
            GetUsers();
            LoadGridData();
        }

        private void GetUsers()
        {
            using (DormitoryDistributionContext _context = new DormitoryDistributionContext())
            {
                var per = _context.Authorizations.ToList();
                 _users = _context.Authorizations.ToList();
            }
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                HiddenIdTextBox.Text = UsersDataGridView.CurrentRow.Cells[0].Value.ToString();
                LoginTextBox.Text = UsersDataGridView.CurrentRow.Cells[1].Value.ToString();
                PasswordTextBox.Text = UsersDataGridView.CurrentRow.Cells[2].Value.ToString();
                IsAdminCheckBox.Checked = (bool)UsersDataGridView.CurrentRow.Cells[3].Value;
            }
            catch
            {
                LoginTextBox.Clear();
                PasswordTextBox.Clear();

            }
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateUsers();
        }

        private void ClearData()
        {
            HiddenIdTextBox.Text = string.Empty;
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            IsAdminCheckBox.Checked = false;
        }

        private void UpdateUsers()
        {
            using (DormitoryDistributionContext _context = new DormitoryDistributionContext())
            {
                var user = new Authorization
                {
                    Id = Int32.Parse(HiddenIdTextBox.Text),
                    Login = LoginTextBox.Text.Trim(),
                    Password = PasswordTextBox.Text.Trim(),
                    IsAdmin = IsAdminCheckBox.Checked
                };

                _context.Entry(user).State = EntityState.Modified;
                LoadGridData();
                _context.SaveChanges();
            }
        }

        private void LoadGridData()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = _users;
            UsersDataGridView.DataSource = binding;
        }
    }
}

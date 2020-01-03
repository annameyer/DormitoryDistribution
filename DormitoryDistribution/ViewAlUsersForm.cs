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
            LoadGridData();
        }

        private void GetUsers()
        {
            using (var _context = new DormitoryDistributionContext())
            {
                List<Authorization> per = _context.Authorizations.ToList();
                _users = _context.Authorizations.ToList();
            }
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Authorization currentUser = GetCurrentUser();
                HiddenIdTextBox.Text = currentUser.Id.ToString();
                LoginTextBox.Text = currentUser.Login;
                PasswordTextBox.Text = currentUser.Password;
                IsAdminCheckBox.Checked = currentUser.IsAdmin;
            }
            catch
            {
                ClearData();

            }
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool modelIsValid = LoginTextBox.Text.Trim() != string.Empty && PasswordTextBox.Text.Trim() != string.Empty;
            bool isOldUser = HiddenIdTextBox.Text.Trim() != string.Empty;
            if (isOldUser)
            {
                UpdateUsers();
            }
            else if (modelIsValid)
            {
                CreateUsers();
            }
            else
            {
                MessageBox.Show("Please, enter all data in field");
            }
        }

        private void UpdateUsers()
        {
            using (var _context = new DormitoryDistributionContext())
            {
                try
                {
                    Authorization user = new Authorization
                    {
                        Id = int.Parse(HiddenIdTextBox.Text),
                        Login = LoginTextBox.Text.Trim(),
                        Password = PasswordTextBox.Text.Trim(),
                        IsAdmin = IsAdminCheckBox.Checked
                    };

                    _context.Entry(user).State = EntityState.Modified;
                    _context.SaveChanges();
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Data update successfule!");
                }
                catch
                {

                }
            }
        }

        private void CreateUsers()
        {
            using (var _context = new DormitoryDistributionContext())
            {
                try
                {
                    Authorization user = new Authorization
                    {
                        Login = LoginTextBox.Text.Trim(),
                        Password = PasswordTextBox.Text.Trim(),
                        IsAdmin = IsAdminCheckBox.Checked
                    };

                    _context.Authorizations.Add(user);
                    _context.SaveChanges();
                    LoadGridData();
                    ClearData();
                    MessageBox.Show("Data save successfule!");
                }
                catch
                {

                }
            }
        }

        private void LoadGridData()
        {
            GetUsers();
            BindingSource binding = new BindingSource
            {
                DataSource = _users
            };

            UsersDataGridView.DataSource = binding;
        }

        private void ClearData()
        {
            HiddenIdTextBox.Text = string.Empty;
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            IsAdminCheckBox.Checked = false;
        }

        private Authorization GetCurrentUser()
        {
            return new Authorization
            {
                Id = (int)UsersDataGridView.CurrentRow.Cells[0].Value,
                Login = UsersDataGridView.CurrentRow.Cells[1].Value.ToString(),
                Password = UsersDataGridView.CurrentRow.Cells[2].Value.ToString(),
                IsAdmin = (bool)UsersDataGridView.CurrentRow.Cells[3].Value
            };
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var _context = new DormitoryDistributionContext())
            {
                try
                {
                    Authorization user = GetCurrentUser();
                    _context.Entry(user).State = EntityState.Deleted;
                    _context.SaveChanges();
                    LoadGridData();
                    MessageBox.Show("Data delete successfule!");
                }
                catch
                {
                    MessageBox.Show("Please, select cell for deleting");
                }
            }

        }
    }
}

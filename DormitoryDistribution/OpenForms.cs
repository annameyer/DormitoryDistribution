using System.Windows.Forms;

namespace DormitoryDistribution
{
    public static class OpenForms
    {
        public static void OpenViewAlUsersForm(Form form)
        {
            var viewAlUsersForm = new ViewAlUsersForm();
            form.Hide();
            viewAlUsersForm.ShowDialog();
            form.Close();
        }

        public static void OpenUserForm(Form form)
        {
            var user = new User();
            form.Hide();
            user.ShowDialog();
            form.Close();
        }

        public static void OpenCreateFirstAdminForm(Form form)
        {
            var admin = new CreateFirstAdmin();
            form.Hide();
            admin.ShowDialog();
            form.Close();
        }

        public static void OpenAdminForm(Form form)
        {
            var admin = new Admin();
            form.Hide();
            admin.ShowDialog();
            form.Close();
        }

        public static void OpenHostelAllocationForm(Form form)
        {
            var hostelAllocationForm = new HostelAllocationForm();
            form.Hide();
            hostelAllocationForm.ShowDialog();
            form.Close();
        }

        public static void OpenAuthorizationForm(Form form)
        {
            var loginForm = new AuthorizationForm();
            form.Hide();
            loginForm.ShowDialog();
            form.Close();
        }
    }
}

using SaleSystem.DataAccess;

namespace SaleSystem
{
    public partial class MainLayout : Form
    {
        private readonly string _username;
        public MainLayout(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataAccessObject dataAccessObject = new DataAccessObject();
            bool isSuccess = dataAccessObject.VerifyRole(_username, "report");
            if (!isSuccess)
            {
                MessageBox.Show("You can't access to this resource!");
                return;
            }

            ReportForm reportForm = new();
            reportForm.TopLevel = false;
            panelForm.Controls.Add(reportForm);
            reportForm.BringToFront();
            reportForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reportForm.Dock = DockStyle.Fill;
            reportForm.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            DataAccessObject dataAccessObject = new DataAccessObject();
            bool isSuccess = dataAccessObject.VerifyRole(_username, "sale");
            if (!isSuccess)
            {
                MessageBox.Show("You can't access to this resource!");
                return;
            }
            SaleFrm saleFrm = new();
            saleFrm.TopLevel = false;
            panelForm.Controls.Add(saleFrm);
            saleFrm.BringToFront();
            saleFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            saleFrm.Dock = DockStyle.Fill;
            saleFrm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm loginFrm = new();
            loginFrm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            DataAccessObject dataAccessObject = new();
            bool isSuccess = dataAccessObject.VerifyRole(_username, "admin"); 
            if (!isSuccess)
            {
                MessageBox.Show("You can't access to this resource!");
                return;
            }
            AdminFrm adminFrm = new();
            adminFrm.TopLevel = false;
            panelForm.Controls.Add(adminFrm);
            adminFrm.BringToFront();
            adminFrm.FormBorderStyle = FormBorderStyle.None;
            adminFrm.Dock = DockStyle.Fill; 
            adminFrm.Show();
        }
    }
}

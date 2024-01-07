using SaleSystem.DataAccess;

namespace SaleSystem
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccessObject dataAccessObject = new();
            bool isSuccess = dataAccessObject.VerifyCredential(txtUser.Text, txtPassword.Text);
            if (isSuccess)
            {
                this.Hide();
                TwoFactorVerifyFrm frm = new TwoFactorVerifyFrm(txtUser.Text);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is invalid!!");
                return;
            }
        }
    }
}
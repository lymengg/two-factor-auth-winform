using SaleSystem.DataAccess;

namespace SaleSystem
{
    public partial class TwoFactorVerifyFrm : Form
    {
        private readonly string username;
        public TwoFactorVerifyFrm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnCode1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCode6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                string[] txtBoxNameList = new[]
                {
                    "txtCode",
                    "txtCode2",
                    "txtCode3",
                    "txtCode4",
                    "txtCode5",
                    "txtCode6"
                };

                TextBox txtBox = ((TextBox)sender);
                if (txtBox.Name != txtBoxNameList[0])
                {
                    for (int i = 0; i <= txtBoxNameList.Length; i++)
                    {
                        if (txtBoxNameList[i].Equals(txtBox.Name))
                        {
                            string txtBoxName = txtBoxNameList[i - 1];
                            Control previous = this.GetNextControl(this.Controls.Find(txtBoxName, true).FirstOrDefault(), false);
                            this.SelectNextControl(previous, true, true, true, true);
                            break;
                        }
                    }
                }
            }
            else
            {
                TextBox txtBox = sender as TextBox;
                if (txtBox.Text.Length + 1 > 0)
                {
                    if (txtBox.Name.ToLower() != "txtCode6".ToLower())
                    {
                        this.SelectNextControl(txtBox, true, true, true, true);
                    }
                    else
                    {
                        txtBox.Focus();
                    }
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string otpCode = txtCode.Text + txtCode2.Text + txtCode3.Text + txtCode4.Text + txtCode5.Text + txtCode6.Text;
            var dataAccessObject = new DataAccessObject();
            bool isSuccess = dataAccessObject.VerifyOTP(username, otpCode);
            if (!isSuccess)
            {
                MessageBox.Show("OTP is not valid!!");
                return;
            }

            MainLayout mainLayoutFrm = new(username);
            mainLayoutFrm.Show();
            this.Hide();
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            var dataAccessObject = new DataAccessObject();
            bool isSuccess = dataAccessObject.ResendOTP(username);
            if (isSuccess)
            {
                MessageBox.Show("OTP has resent!");
            }
        }
    }
}

namespace SaleSystem
{
    public partial class MainLayout : Form
    {
        public MainLayout()
        {
            InitializeComponent();
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleFrm saleFrm = new SaleFrm();
            saleFrm.TopLevel = false;
            panelForm.Controls.Add(saleFrm);
            saleFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            saleFrm.Dock = DockStyle.Fill;
            saleFrm.Show();
        }
    }
}

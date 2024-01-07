namespace SaleSystem
{
    partial class MainLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayout));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnReport = new Button();
            panel4 = new Panel();
            btnSale = new Button();
            panel2 = new Panel();
            btnAdmin = new Button();
            panelForm = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(44, 88, 108);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(187, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 51);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(57, 14);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 1;
            label1.Text = "Sale Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 88, 108);
            panel3.Controls.Add(btnReport);
            panel3.Location = new Point(3, 77);
            panel3.Margin = new Padding(3, 20, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 41);
            panel3.TabIndex = 2;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(44, 88, 108);
            btnReport.ForeColor = SystemColors.ButtonHighlight;
            btnReport.Location = new Point(-27, -18);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(234, 76);
            btnReport.TabIndex = 0;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 88, 108);
            panel4.Controls.Add(btnSale);
            panel4.Location = new Point(3, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 41);
            panel4.TabIndex = 2;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.FromArgb(44, 88, 108);
            btnSale.ForeColor = SystemColors.ButtonHighlight;
            btnSale.Location = new Point(-27, -18);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(234, 76);
            btnSale.TabIndex = 0;
            btnSale.Text = "Sale";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 88, 108);
            panel2.Controls.Add(btnAdmin);
            panel2.Location = new Point(3, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 41);
            panel2.TabIndex = 3;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(44, 88, 108);
            btnAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnAdmin.Location = new Point(-27, -18);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(234, 76);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // panelForm
            // 
            panelForm.Location = new Point(187, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(614, 450);
            panelForm.TabIndex = 1;
            // 
            // MainLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainLayout";
            Load += MainLayout_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Button btnReport;
        private Panel panel4;
        private Button btnSale;
        private Panel panel2;
        private Button btnAdmin;
        private Panel panelForm;
    }
}
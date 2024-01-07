namespace SaleSystem
{
    partial class TwoFactorVerifyFrm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtCode2 = new TextBox();
            txtCode4 = new TextBox();
            txtCode3 = new TextBox();
            txtCode5 = new TextBox();
            txtCode6 = new TextBox();
            btnResend = new Button();
            txtCode = new TextBox();
            btnVerify = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 90);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 60);
            label2.Name = "label2";
            label2.Size = new Size(384, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter the verification code from your authentication app.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 18);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 0;
            label1.Text = "Two-factor authentication";
            // 
            // txtCode2
            // 
            txtCode2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode2.Location = new Point(178, 107);
            txtCode2.MaxLength = 1;
            txtCode2.Multiline = true;
            txtCode2.Name = "txtCode2";
            txtCode2.Size = new Size(61, 61);
            txtCode2.TabIndex = 1;
            txtCode2.TextAlign = HorizontalAlignment.Center;
            txtCode2.TextChanged += btnCode1_TextChanged;
            txtCode2.KeyDown += txtCode6_KeyDown;
            // 
            // txtCode4
            // 
            txtCode4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode4.Location = new Point(312, 107);
            txtCode4.MaxLength = 1;
            txtCode4.Multiline = true;
            txtCode4.Name = "txtCode4";
            txtCode4.Size = new Size(61, 61);
            txtCode4.TabIndex = 3;
            txtCode4.TextAlign = HorizontalAlignment.Center;
            txtCode4.TextChanged += btnCode1_TextChanged;
            txtCode4.KeyDown += txtCode6_KeyDown;
            // 
            // txtCode3
            // 
            txtCode3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode3.Location = new Point(245, 107);
            txtCode3.MaxLength = 1;
            txtCode3.Multiline = true;
            txtCode3.Name = "txtCode3";
            txtCode3.Size = new Size(61, 61);
            txtCode3.TabIndex = 2;
            txtCode3.TextAlign = HorizontalAlignment.Center;
            txtCode3.TextChanged += btnCode1_TextChanged;
            txtCode3.KeyDown += txtCode6_KeyDown;
            // 
            // txtCode5
            // 
            txtCode5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode5.Location = new Point(379, 107);
            txtCode5.MaxLength = 1;
            txtCode5.Multiline = true;
            txtCode5.Name = "txtCode5";
            txtCode5.Size = new Size(61, 61);
            txtCode5.TabIndex = 4;
            txtCode5.TextAlign = HorizontalAlignment.Center;
            txtCode5.TextChanged += btnCode1_TextChanged;
            txtCode5.KeyDown += txtCode6_KeyDown;
            // 
            // txtCode6
            // 
            txtCode6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode6.Location = new Point(446, 107);
            txtCode6.MaxLength = 1;
            txtCode6.Multiline = true;
            txtCode6.Name = "txtCode6";
            txtCode6.Size = new Size(61, 61);
            txtCode6.TabIndex = 5;
            txtCode6.TextAlign = HorizontalAlignment.Center;
            txtCode6.TextChanged += btnCode1_TextChanged;
            txtCode6.KeyDown += txtCode6_KeyDown;
            // 
            // btnResend
            // 
            btnResend.Location = new Point(111, 183);
            btnResend.Name = "btnResend";
            btnResend.Size = new Size(195, 40);
            btnResend.TabIndex = 6;
            btnResend.TabStop = false;
            btnResend.Text = "Resend";
            btnResend.UseVisualStyleBackColor = true;
            btnResend.Click += btnResend_Click;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(111, 107);
            txtCode.MaxLength = 1;
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(61, 61);
            txtCode.TabIndex = 0;
            txtCode.TextAlign = HorizontalAlignment.Center;
            txtCode.TextChanged += btnCode1_TextChanged;
            txtCode.KeyDown += txtCode6_KeyDown;
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(312, 183);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(195, 40);
            btnVerify.TabIndex = 7;
            btnVerify.TabStop = false;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // TwoFactorVerifyFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 382);
            Controls.Add(btnVerify);
            Controls.Add(txtCode);
            Controls.Add(btnResend);
            Controls.Add(txtCode6);
            Controls.Add(txtCode5);
            Controls.Add(txtCode3);
            Controls.Add(txtCode4);
            Controls.Add(txtCode2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TwoFactorVerifyFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TwoFactorVerifyFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtCode2;
        private TextBox txtCode4;
        private TextBox txtCode3;
        private TextBox txtCode5;
        private TextBox txtCode6;
        private Button btnResend;
        private TextBox txtCode;
        private Button btnVerify;
    }
}
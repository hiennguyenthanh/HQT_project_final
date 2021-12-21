
namespace HeThongVanChuyen
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelDangNhap;
            this.pnLogin = new System.Windows.Forms.Panel();
            this.linkDangKy = new System.Windows.Forms.LinkLabel();
            this.labelChuaDK = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            labelDangNhap = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDangNhap
            // 
            labelDangNhap.AutoSize = true;
            labelDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDangNhap.ForeColor = System.Drawing.SystemColors.HighlightText;
            labelDangNhap.Location = new System.Drawing.Point(59, 93);
            labelDangNhap.Name = "labelDangNhap";
            labelDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            labelDangNhap.Size = new System.Drawing.Size(188, 41);
            labelDangNhap.TabIndex = 0;
            labelDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.pnLogin.Controls.Add(this.linkDangKy);
            this.pnLogin.Controls.Add(this.labelChuaDK);
            this.pnLogin.Controls.Add(this.btnDangNhap);
            this.pnLogin.Controls.Add(this.txbMatKhau);
            this.pnLogin.Controls.Add(this.labelMatKhau);
            this.pnLogin.Controls.Add(this.txbTenDangNhap);
            this.pnLogin.Controls.Add(this.labelTenDangNhap);
            this.pnLogin.Controls.Add(labelDangNhap);
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(297, 610);
            this.pnLogin.TabIndex = 0;
            // 
            // linkDangKy
            // 
            this.linkDangKy.AutoSize = true;
            this.linkDangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkDangKy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.linkDangKy.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkDangKy.Location = new System.Drawing.Point(176, 581);
            this.linkDangKy.Name = "linkDangKy";
            this.linkDangKy.Size = new System.Drawing.Size(66, 20);
            this.linkDangKy.TabIndex = 4;
            this.linkDangKy.TabStop = true;
            this.linkDangKy.Text = "Đăng ký";
            this.linkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangKy_LinkClicked);
            // 
            // labelChuaDK
            // 
            this.labelChuaDK.AutoSize = true;
            this.labelChuaDK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChuaDK.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelChuaDK.Location = new System.Drawing.Point(47, 581);
            this.labelChuaDK.Name = "labelChuaDK";
            this.labelChuaDK.Size = new System.Drawing.Size(135, 20);
            this.labelChuaDK.TabIndex = 4;
            this.labelChuaDK.Text = "Chưa có tài khoản?";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhap.Location = new System.Drawing.Point(84, 410);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(132, 42);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMatKhau.Location = new System.Drawing.Point(32, 349);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(238, 34);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMatKhau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMatKhau.Location = new System.Drawing.Point(32, 318);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(94, 28);
            this.labelMatKhau.TabIndex = 2;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTenDangNhap.Location = new System.Drawing.Point(32, 269);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(238, 34);
            this.txbTenDangNhap.TabIndex = 1;
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTenDangNhap.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTenDangNhap.Location = new System.Drawing.Point(32, 238);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(140, 28);
            this.labelTenDangNhap.TabIndex = 1;
            this.labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HeThongVanChuyen.Properties.Resources.LoginPic1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(294, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 611);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnLogin);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.LinkLabel linkDangKy;
        private System.Windows.Forms.Label labelChuaDK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



namespace HeThongVanChuyen
{
    partial class SignUp_Success
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
            System.Windows.Forms.Label label;
            this.pnChonLoaiUser = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            this.pnChonLoaiUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChonLoaiUser
            // 
            this.pnChonLoaiUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.pnChonLoaiUser.Controls.Add(label);
            this.pnChonLoaiUser.Controls.Add(this.btnDangNhap);
            this.pnChonLoaiUser.Controls.Add(this.label1);
            this.pnChonLoaiUser.Location = new System.Drawing.Point(0, -1);
            this.pnChonLoaiUser.Name = "pnChonLoaiUser";
            this.pnChonLoaiUser.Size = new System.Drawing.Size(297, 610);
            this.pnChonLoaiUser.TabIndex = 13;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label.Location = new System.Drawing.Point(71, 61);
            label.Name = "label";
            label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label.Size = new System.Drawing.Size(144, 41);
            label.TabIndex = 0;
            label.Text = "ĐĂNG KÝ";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhap.Location = new System.Drawing.Point(72, 336);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(132, 42);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(27, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tạo tài khoản thành công!";
            // 
            // SignUp_Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 610);
            this.Controls.Add(this.pnChonLoaiUser);
            this.Name = "SignUp_Success";
            this.Text = "SignUp_Success";
            this.pnChonLoaiUser.ResumeLayout(false);
            this.pnChonLoaiUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChonLoaiUser;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
    }
}
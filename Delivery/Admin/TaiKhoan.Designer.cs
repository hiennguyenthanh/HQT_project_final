
namespace Delivery.Admin
{
    partial class TaiKhoan
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
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.ckb_kichhoat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_khoa = new System.Windows.Forms.CheckBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(0, 191);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersWidth = 51;
            this.dgv_taikhoan.RowTemplate.Height = 24;
            this.dgv_taikhoan.Size = new System.Drawing.Size(758, 283);
            this.dgv_taikhoan.TabIndex = 0;
            this.dgv_taikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellContentClick);
            // 
            // ckb_kichhoat
            // 
            this.ckb_kichhoat.AutoSize = true;
            this.ckb_kichhoat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_kichhoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckb_kichhoat.Location = new System.Drawing.Point(339, 76);
            this.ckb_kichhoat.Name = "ckb_kichhoat";
            this.ckb_kichhoat.Size = new System.Drawing.Size(159, 23);
            this.ckb_kichhoat.TabIndex = 2;
            this.ckb_kichhoat.Text = "Kích hoạt tài khoản";
            this.ckb_kichhoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(259, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // ckb_khoa
            // 
            this.ckb_khoa.AutoSize = true;
            this.ckb_khoa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_khoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckb_khoa.Location = new System.Drawing.Point(508, 76);
            this.ckb_khoa.Name = "ckb_khoa";
            this.ckb_khoa.Size = new System.Drawing.Size(131, 23);
            this.ckb_khoa.TabIndex = 4;
            this.ckb_khoa.Text = "Khóa tài khoản";
            this.ckb_khoa.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_luu.Location = new System.Drawing.Point(650, 66);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 36);
            this.bt_luu.TabIndex = 5;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(509, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 60);
            this.label3.TabIndex = 7;
            this.label3.Text = "0: khóa \r\n1: Đã kích hoạt \r\n2: Chưa kích hoạt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(360, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trạng thái tài khoản";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(120, 79);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(100, 25);
            this.tb_taikhoan.TabIndex = 9;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(758, 472);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.ckb_khoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckb_kichhoat);
            this.Controls.Add(this.dgv_taikhoan);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.CheckBox ckb_kichhoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_khoa;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_taikhoan;
    }
}
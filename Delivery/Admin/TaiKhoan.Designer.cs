
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb_taikhoan = new System.Windows.Forms.ComboBox();
            this.ckb_kichhoat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_khoa = new System.Windows.Forms.CheckBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbb_taikhoan
            // 
            this.cbb_taikhoan.FormattingEnabled = true;
            this.cbb_taikhoan.Location = new System.Drawing.Point(89, 73);
            this.cbb_taikhoan.Name = "cbb_taikhoan";
            this.cbb_taikhoan.Size = new System.Drawing.Size(181, 24);
            this.cbb_taikhoan.TabIndex = 1;
            // 
            // ckb_kichhoat
            // 
            this.ckb_kichhoat.AutoSize = true;
            this.ckb_kichhoat.Location = new System.Drawing.Point(339, 72);
            this.ckb_kichhoat.Name = "ckb_kichhoat";
            this.ckb_kichhoat.Size = new System.Drawing.Size(151, 21);
            this.ckb_kichhoat.TabIndex = 2;
            this.ckb_kichhoat.Text = "Kích hoạt tài khoản";
            this.ckb_kichhoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(259, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // ckb_khoa
            // 
            this.ckb_khoa.AutoSize = true;
            this.ckb_khoa.Location = new System.Drawing.Point(508, 72);
            this.ckb_khoa.Name = "ckb_khoa";
            this.ckb_khoa.Size = new System.Drawing.Size(125, 21);
            this.ckb_khoa.TabIndex = 4;
            this.ckb_khoa.Text = "Khóa tài khoản";
            this.ckb_khoa.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_save.Location = new System.Drawing.Point(650, 62);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 34);
            this.bt_save.TabIndex = 5;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài khoản";
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.ckb_khoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckb_kichhoat);
            this.Controls.Add(this.cbb_taikhoan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_taikhoan;
        private System.Windows.Forms.CheckBox ckb_kichhoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_khoa;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label2;
    }
}
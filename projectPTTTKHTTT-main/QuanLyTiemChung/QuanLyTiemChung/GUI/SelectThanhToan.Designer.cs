
namespace QuanLyTiemChung
{
    partial class SelectThanhToan
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
            this.btnTTToanBo = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btnTTTheoDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTTToanBo
            // 
            this.btnTTToanBo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTTToanBo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnTTToanBo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnTTToanBo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnTTToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTToanBo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTToanBo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTTToanBo.Location = new System.Drawing.Point(104, 93);
            this.btnTTToanBo.Margin = new System.Windows.Forms.Padding(3, 19, 3, 2);
            this.btnTTToanBo.Name = "btnTTToanBo";
            this.btnTTToanBo.Size = new System.Drawing.Size(504, 56);
            this.btnTTToanBo.TabIndex = 2;
            this.btnTTToanBo.Text = "Thanh toán toàn bộ";
            this.btnTTToanBo.UseVisualStyleBackColor = true;
            this.btnTTToanBo.Click += new System.EventHandler(this.btnTTToanBo_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lbThongBao.ForeColor = System.Drawing.Color.Yellow;
            this.lbThongBao.Location = new System.Drawing.Point(112, 195);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(496, 31);
            this.lbThongBao.TabIndex = 5;
            this.lbThongBao.Text = "Chỉ dành cho đơn trên 1.500.000đ";
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThongBao.Visible = false;
            // 
            // btnTTTheoDot
            // 
            this.btnTTTheoDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTTTheoDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnTTTheoDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnTTTheoDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnTTTheoDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTTheoDot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTTheoDot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTTTheoDot.Location = new System.Drawing.Point(104, 225);
            this.btnTTTheoDot.Margin = new System.Windows.Forms.Padding(3, 19, 3, 2);
            this.btnTTTheoDot.Name = "btnTTTheoDot";
            this.btnTTTheoDot.Size = new System.Drawing.Size(504, 56);
            this.btnTTTheoDot.TabIndex = 6;
            this.btnTTTheoDot.Text = "Thanh toán theo đợt";
            this.btnTTTheoDot.UseVisualStyleBackColor = true;
            this.btnTTTheoDot.Click += new System.EventHandler(this.btnTTTheoDot_Click);
            // 
            // SelectThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(724, 379);
            this.Controls.Add(this.btnTTTheoDot);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btnTTToanBo);
            this.Name = "SelectThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn hình thức thanh toán";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTTToanBo;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Button btnTTTheoDot;
    }
}
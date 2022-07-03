
namespace QuanLyTiemChung
{
    partial class HoaDonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.btnHoaDonPhieuDangKy = new System.Windows.Forms.Button();
            this.btnHoaDonPhieuDatMua = new System.Windows.Forms.Button();
            this.dtgvHoaDonPDK = new System.Windows.Forms.DataGridView();
            this.MaHDPDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaiSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonPDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbMaKH);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 99);
            this.panel1.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.lbMaKH.Location = new System.Drawing.Point(706, 34);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(205, 37);
            this.lbMaKH.TabIndex = 120;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.lbHoTen.Location = new System.Drawing.Point(937, 34);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(263, 37);
            this.lbHoTen.TabIndex = 119;
            this.lbHoTen.Text = "Nguyễn Thị Nguyễn";
            // 
            // btnHoaDonPhieuDangKy
            // 
            this.btnHoaDonPhieuDangKy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnHoaDonPhieuDangKy.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHoaDonPhieuDangKy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnHoaDonPhieuDangKy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnHoaDonPhieuDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonPhieuDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonPhieuDangKy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHoaDonPhieuDangKy.Location = new System.Drawing.Point(39, 144);
            this.btnHoaDonPhieuDangKy.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoaDonPhieuDangKy.Name = "btnHoaDonPhieuDangKy";
            this.btnHoaDonPhieuDangKy.Size = new System.Drawing.Size(406, 50);
            this.btnHoaDonPhieuDangKy.TabIndex = 148;
            this.btnHoaDonPhieuDangKy.Text = "Hóa đơn đăng ký tiêm chủng";
            this.btnHoaDonPhieuDangKy.UseVisualStyleBackColor = true;
            this.btnHoaDonPhieuDangKy.Click += new System.EventHandler(this.btnHoaDonPhieuDangKy_Click);
            // 
            // btnHoaDonPhieuDatMua
            // 
            this.btnHoaDonPhieuDatMua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnHoaDonPhieuDatMua.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHoaDonPhieuDatMua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.btnHoaDonPhieuDatMua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(217)))));
            this.btnHoaDonPhieuDatMua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonPhieuDatMua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonPhieuDatMua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHoaDonPhieuDatMua.Location = new System.Drawing.Point(746, 144);
            this.btnHoaDonPhieuDatMua.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoaDonPhieuDatMua.Name = "btnHoaDonPhieuDatMua";
            this.btnHoaDonPhieuDatMua.Size = new System.Drawing.Size(406, 50);
            this.btnHoaDonPhieuDatMua.TabIndex = 149;
            this.btnHoaDonPhieuDatMua.Text = "Hóa đơn mua vắc xin";
            this.btnHoaDonPhieuDatMua.UseVisualStyleBackColor = true;
            // 
            // dtgvHoaDonPDK
            // 
            this.dtgvHoaDonPDK.AllowUserToAddRows = false;
            this.dtgvHoaDonPDK.AllowUserToDeleteRows = false;
            this.dtgvHoaDonPDK.AllowUserToOrderColumns = true;
            this.dtgvHoaDonPDK.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dtgvHoaDonPDK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoaDonPDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHoaDonPDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDonPDK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dtgvHoaDonPDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHoaDonPDK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvHoaDonPDK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoaDonPDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHoaDonPDK.ColumnHeadersHeight = 30;
            this.dtgvHoaDonPDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvHoaDonPDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDPDK,
            this.MaPhieu,
            this.NgayLap,
            this.GioTiem,
            this.LaiSuat,
            this.TongTien,
            this.TrangThai,
            this.MoTa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHoaDonPDK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHoaDonPDK.EnableHeadersVisualStyles = false;
            this.dtgvHoaDonPDK.Location = new System.Drawing.Point(54, 234);
            this.dtgvHoaDonPDK.Margin = new System.Windows.Forms.Padding(45, 50, 45, 50);
            this.dtgvHoaDonPDK.Name = "dtgvHoaDonPDK";
            this.dtgvHoaDonPDK.ReadOnly = true;
            this.dtgvHoaDonPDK.RowHeadersVisible = false;
            this.dtgvHoaDonPDK.RowHeadersWidth = 51;
            this.dtgvHoaDonPDK.RowTemplate.Height = 50;
            this.dtgvHoaDonPDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDonPDK.Size = new System.Drawing.Size(1108, 365);
            this.dtgvHoaDonPDK.TabIndex = 150;
            this.dtgvHoaDonPDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDonPDK_CellClick);
            // 
            // MaHDPDK
            // 
            this.MaHDPDK.HeaderText = "Mã hóa đơn";
            this.MaHDPDK.MinimumWidth = 8;
            this.MaHDPDK.Name = "MaHDPDK";
            this.MaHDPDK.ReadOnly = true;
            // 
            // MaPhieu
            // 
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 8;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // GioTiem
            // 
            this.GioTiem.HeaderText = "Ngày trả";
            this.GioTiem.MinimumWidth = 8;
            this.GioTiem.Name = "GioTiem";
            this.GioTiem.ReadOnly = true;
            // 
            // LaiSuat
            // 
            this.LaiSuat.HeaderText = "Lãi suất";
            this.LaiSuat.MinimumWidth = 8;
            this.LaiSuat.Name = "LaiSuat";
            this.LaiSuat.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.Location = new System.Drawing.Point(955, 653);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(174, 58);
            this.btnThanhToan.TabIndex = 151;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1238, 768);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtgvHoaDonPDK);
            this.Controls.Add(this.btnHoaDonPhieuDatMua);
            this.Controls.Add(this.btnHoaDonPhieuDangKy);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonPDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Button btnHoaDonPhieuDangKy;
        private System.Windows.Forms.Button btnHoaDonPhieuDatMua;
        private System.Windows.Forms.DataGridView dtgvHoaDonPDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDPDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaiSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.Button btnThanhToan;
    }
}
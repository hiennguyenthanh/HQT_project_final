﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public partial class PhieuDangKyTiemChungForm : Form
    {
        private KhachHang _kh;
        public PhieuDangKyTiemChungForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy phiếu đăng ký không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinNguoiGiamHoForm TTNGH = new ThongTinNguoiGiamHoForm(_kh);
            TTNGH.ShowDialog();
            this.Close();
        }
    }
}

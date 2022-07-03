using System;
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
            DisplayData(_kh);
        }

        private void DisplayData(KhachHang kh)
        {
            txbHoten.ReadOnly = true;
            txbCMND.ReadOnly = true;
            txbBHYT.ReadOnly = true;
            txbDiachi.ReadOnly = true;
            txbEmail.ReadOnly = true;
            txbGioitinh.ReadOnly = true;
            txbSDT.ReadOnly = true;
            txbNgaySinh.ReadOnly = true;

            txbHoten.Text = kh.Hoten;
            txbCMND.Text = kh.SoCMND;
            txbBHYT.Text = kh.BHYT;
            txbDiachi.Text = kh.DiaChi;
            txbEmail.Text = kh.Email;
            txbGioitinh.Text = kh.GioiTinh;
            txbSDT.Text = kh.SoDT;
            txbNgaySinh.Text = kh.NgaySinh;
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
            if(KhachHangBUS.CalculateAge(_kh.NgaySinh) >= 18)
            {
                DangKyGoiVacXinForm DKGVX = new DangKyGoiVacXinForm(_kh, new NguoiGiamHo("", "", "", "", "", "", ""));
                DKGVX.ShowDialog();
            }
            else
            {
                ThongTinNguoiGiamHoForm TTNGH = new ThongTinNguoiGiamHoForm(_kh, new NguoiGiamHo("", "", "", "", "", "", ""));
                TTNGH.ShowDialog();
            }
            this.Close();
        }
    }
}

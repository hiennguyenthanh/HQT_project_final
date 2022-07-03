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
    public partial class InformationForm : Form
    {
        private KhachHang _kh;
        public InformationForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
            DisplayData(_kh);
        }

        private void DisplayData(KhachHang kh)
        {
            lbID1.Text = kh.MaKH;
            lbID2.Text = kh.MaKH;
            txbHoTen.Text = kh.Hoten;
            txbNgaySinh.Text = kh.NgaySinh;
            txbCMND.Text = kh.SoCMND;
            txbDienThoai.Text = kh.SoDT;
            txbDiaChi.Text = kh.DiaChi;
            txbEmail.Text = kh.Email;
            txbMatKhau.Text = kh.MatKhau;
            txbBHYT.Text = kh.BHYT;

            lbNgayHH.Visible = false;
            dtpkNgayHH.Visible = false;
            btnCapNhatBHYT.Visible = false;
        }

        private void btnSuaDoiBHYT_Click(object sender, EventArgs e)
        {
            lbNgayHH.Visible = true;
            dtpkNgayHH.Visible = true;
            btnCapNhatBHYT.Visible = true;
            txbBHYT.ReadOnly = false;
        }

        private void btnCapNhatBHYT_Click(object sender, EventArgs e)
        {
            if (BhytBUS.UpdateBHYT(new Bhyt(txbBHYT.Text, dtpkNgayHH.Text), _kh))
            {
                lbNgayHH.Visible = false;
                dtpkNgayHH.Visible = false;
                btnCapNhatBHYT.Visible = false;
                txbBHYT.ReadOnly = true;
                txbBHYT.Text = _kh.BHYT;
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                lbNgayHH.Visible = false;
                dtpkNgayHH.Visible = false;
                btnCapNhatBHYT.Visible = false;
                txbBHYT.ReadOnly = true;
                txbBHYT.Text = _kh.BHYT;
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}

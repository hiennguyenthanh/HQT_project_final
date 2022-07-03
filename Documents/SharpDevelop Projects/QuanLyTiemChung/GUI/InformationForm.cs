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
        }
    }
}

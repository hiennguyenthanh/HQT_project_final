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
    public partial class XuatHDThanhToanTheoDot : Form
    {
        private KhachHang _kh;
        private PhieuDangKy _pdk;
        private int soThang = 0;
        public XuatHDThanhToanTheoDot(KhachHang kh, PhieuDangKy pdk)
        {
            InitializeComponent();
            _kh = kh;
            _pdk = pdk;
            LoadData();
        }

        private void LoadData()
        {
            txbMaKH.Text = _kh.MaKH;
            txbHoten.Text = _kh.Hoten;
            txbSoTienGoc.Text = _pdk.TongTien.ToString();
        }

        private void radiobtn3thang_Click(object sender, EventArgs e)
        {
            txbLaiSuat.Text = "2.8%";
            double TTien = Math.Round(_pdk.TongTien * Math.Pow(1.0028, 3), 2);
            txbTongTien.Text = TTien.ToString();
            txbGopHangThang.Text = Math.Round((TTien / 3), 2).ToString();
            txbChenhLechTTTB.Text = Math.Round(TTien - _pdk.TongTien, 2).ToString();
            soThang = 3;
        }

        private void radiobtn6thang_Click(object sender, EventArgs e)
        {
            if (PhieuDangKyBUS.KiemtraTongTien(_kh, _pdk.MaPhieu) == 2)
            {
                radiobtn6thang.Checked = false;
                MessageBox.Show("Trả góp 6 tháng chỉ dành cho đơn từ 3 triệu trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txbLaiSuat.Text = "2.8%";
            double TTien = Math.Round(_pdk.TongTien * Math.Pow(1.0028, 6), 2);
            txbTongTien.Text = TTien.ToString();
            txbGopHangThang.Text = Math.Round((TTien / 6), 2).ToString();
            txbChenhLechTTTB.Text = Math.Round(TTien - _pdk.TongTien, 2).ToString();
            soThang = 6;
        }

        private void radiobtn9thang_Click(object sender, EventArgs e)
        {
            if (PhieuDangKyBUS.KiemtraTongTien(_kh, _pdk.MaPhieu) == 3)
            {
                radiobtn6thang.Checked = false;
                MessageBox.Show("Trả góp 9 tháng chỉ dành cho đơn từ 4,5 triệu trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txbLaiSuat.Text = "2.8%";
            double TTien = Math.Round(_pdk.TongTien * Math.Pow(1.0028, 9), 2);
            txbTongTien.Text = TTien.ToString();
            txbGopHangThang.Text = Math.Round((TTien / 9), 2).ToString();
            txbChenhLechTTTB.Text = Math.Round(TTien - _pdk.TongTien, 2).ToString();
            soThang = 9;
        }

        private void radiobtn12thang_Click(object sender, EventArgs e)
        {
            if (PhieuDangKyBUS.KiemtraTongTien(_kh, _pdk.MaPhieu) == 4)
            {
                radiobtn6thang.Checked = false;
                MessageBox.Show("Trả góp 12 tháng chỉ dành cho đơn từ 6 triệu trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txbLaiSuat.Text = "2.8%";
            double TTien = Math.Round(_pdk.TongTien * Math.Pow(1.0028, 12), 2);
            txbTongTien.Text = TTien.ToString();
            txbGopHangThang.Text = Math.Round((TTien / 12), 2).ToString();
            txbChenhLechTTTB.Text = Math.Round(TTien - _pdk.TongTien, 2).ToString();
            soThang = 12;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<HoaDonPhieuDangKy> listhd = new List<HoaDonPhieuDangKy>(soThang);
            for (int i = 0; i < soThang; i++)
            {
                HoaDonPhieuDangKy _hd = new HoaDonPhieuDangKy("", _pdk.MaPhieu, DateTime.Now.ToString(), 0,
                    0, DateTime.Now.ToString(), 0.028, "123", "Đợt " + (i + 1).ToString());
                HoaDonPhieuDangKyBUS.addHoaDonPDK(_kh, _hd);
                _hd = null;
            }

            if (PhieuDangKyBUS.CapNhatTinhTrang(_pdk.MaPhieu))
            {
                MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xuất hóa không đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}

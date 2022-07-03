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
    public partial class XuatHDThanhToanToanBo : Form
    {
        private KhachHang _kh;
        private PhieuDangKy _pdk;
        public XuatHDThanhToanToanBo(KhachHang kh, PhieuDangKy pdk)
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
            txbTongTien.Text = _pdk.TongTien.ToString();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonPhieuDangKy _hd = new HoaDonPhieuDangKy("", _pdk.MaPhieu, DateTime.Now.ToString(), 0,
                0, DateTime.Now.ToString(), 0, "123", "Thanh toán toàn bộ");
            HoaDonPhieuDangKyBUS.addHoaDonPDK(_kh, _hd);

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

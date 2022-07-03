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
    public partial class ThanhToanForm : Form
    {
        private KhachHang _kh;
        private HoaDonPhieuDangKy _hdpdk;
        private List<SoTaiKhoan> _listSTK;
        private SoTaiKhoan _stk;

        public ThanhToanForm(KhachHang kh, HoaDonPhieuDangKy hdpdk)
        {
            InitializeComponent();
            _kh = kh;
            _hdpdk = hdpdk;
            LoadData();
        }

        private void LoadData()
        {
            txbMaKH.Text = _kh.MaKH;
            txbHoten.Text = _kh.Hoten;
            txbTGTT.Text = DateTime.Now.ToString("g");
            txbTongTien.Text = _hdpdk.TongTien.ToString();
            _listSTK = SoTaiKhoanBUS.GetlistSTK(_kh.MaKH);

            cbxSTK.DataSource = _listSTK;
            cbxSTK.DisplayMember = "SoTk";
        }
        //kiem tra stk
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (!SoTaiKhoanBUS.KiemTraSoDu(_stk, _hdpdk.TongTien))
            {
                MessageBox.Show("Không đủ tiền trong tài khoản", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (HoaDonPhieuDangKyBUS.CapNhatTinhTrang(_hdpdk.MaHDPDK))
                {
                    this.Hide();
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật trạng thái hóa đơn", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }



            }
        }

        private void cbxSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            SoTaiKhoan selected = cb.SelectedItem as SoTaiKhoan;
            _stk = SoTaiKhoanBUS.GetSTK(selected.SoTK, selected.NganHang);
        }
    }
}

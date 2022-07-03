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
    public partial class SelectionForm : Form
    {
        private KhachHang _kh;
        public SelectionForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
        }

        private void btnDKTiemChung_Click(object sender, EventArgs e)
        {
            PhieuDangKyTiemChungForm PDK = new PhieuDangKyTiemChungForm(_kh);
            PDK.ShowDialog();
        }

        private void btnXemPhieuDangKy_Click(object sender, EventArgs e)
        {
            ChiTietPhieuDangKyForm CTPDK = new ChiTietPhieuDangKyForm(_kh);
            CTPDK.ShowDialog();
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonForm HD = new HoaDonForm(_kh);
            HD.ShowDialog();
        }
    }
}

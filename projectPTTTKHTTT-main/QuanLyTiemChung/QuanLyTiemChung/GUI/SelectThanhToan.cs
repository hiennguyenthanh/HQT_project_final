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
    public partial class SelectThanhToan : Form
    {
        private KhachHang _kh;
        private PhieuDangKy _pdk;

        public SelectThanhToan(KhachHang kh, string mapdk)
        {
            InitializeComponent();
            _kh = kh;
            _pdk = PhieuDangKyBUS.getPhieuDangKy(_kh, mapdk);
            LoadData();
        }

        private void LoadData()
        {
            if (_pdk.TongTien <= 1500000)
            {
                btnTTTheoDot.Enabled = false;
                lbThongBao.Visible = true;
            }
        }

        private void btnTTToanBo_Click(object sender, EventArgs e)
        {
            XuatHDThanhToanToanBo TTTB = new XuatHDThanhToanToanBo(_kh, _pdk);
            this.Hide();
            TTTB.ShowDialog();
        }

        private void btnTTTheoDot_Click(object sender, EventArgs e)
        {
            XuatHDThanhToanTheoDot TTTD = new XuatHDThanhToanTheoDot(_kh, _pdk);
            this.Hide();
            TTTD.ShowDialog();
        }
    }
}

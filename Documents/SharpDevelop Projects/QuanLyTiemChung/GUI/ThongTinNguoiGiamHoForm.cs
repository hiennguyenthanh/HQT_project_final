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
    public partial class ThongTinNguoiGiamHoForm : Form
    {
        private KhachHang _kh;
        public ThongTinNguoiGiamHoForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyGoiVacXinForm DKVX = new DangKyGoiVacXinForm(_kh);
            DKVX.ShowDialog();
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuDangKyTiemChungForm PDK = new PhieuDangKyTiemChungForm(_kh);
            PDK.ShowDialog();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy phiếu đăng ký không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }
    }
}

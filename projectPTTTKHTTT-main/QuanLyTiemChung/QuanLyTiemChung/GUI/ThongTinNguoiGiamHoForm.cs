using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace QuanLyTiemChung
{
    public partial class ThongTinNguoiGiamHoForm : Form
    {
        private KhachHang _kh;
        private NguoiGiamHo _ngh;
        public ThongTinNguoiGiamHoForm(KhachHang kh, NguoiGiamHo ngh)
        {
            InitializeComponent();
            _kh = kh;
            _ngh = ngh;
            DisplayData(_kh);
        }

        private void DisplayData(KhachHang kh)
        {
            List<NguoiGiamHo> list = NguoiGiamHoBUS.GetNguoiGiamHoByMaKH(kh.MaKH);
            if (list.Count > 0)
                _ngh = list[0];
            cbxGioiTinh.Text = _ngh.GioiTinh;
            txbHoTen.Text = _ngh.HoTen;
            txbCMND.Text = _ngh.SoCMND;
            txbSDT.Text = _ngh.SoDT;
            dtpkNgaySinh.Text = _ngh.NgaySinh;
            txbDiaChi.Text = _ngh.DiaChi;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _ngh = new NguoiGiamHo("", txbHoTen.Text, dtpkNgaySinh.Text, txbCMND.Text, txbSDT.Text, txbDiaChi.Text, cbxGioiTinh.Text);
            if (NguoiGiamHoBUS.CalculateAge(_ngh.NgaySinh) < 25)
            {
                MessageBox.Show("Tuổi người giám hộ phải từ 25 trở lên");
            }
            else if(_ngh.HoTen == "" || _ngh.SoCMND == "" || _ngh.SoDT == "" || _ngh.DiaChi == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                this.Hide();
                DangKyGoiVacXinForm DKVX = new DangKyGoiVacXinForm(_kh, _ngh);
                DKVX.ShowDialog();
                this.Close();
            }
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

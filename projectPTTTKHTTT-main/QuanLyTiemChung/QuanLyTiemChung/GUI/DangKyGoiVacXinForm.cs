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
    public partial class DangKyGoiVacXinForm : Form
    {
        private KhachHang _kh;
        private NguoiGiamHo _ngh;
        private List<VacXin> _vx;
        public DangKyGoiVacXinForm(KhachHang kh, NguoiGiamHo ngh)
        {
            InitializeComponent();
            _kh = kh;
            _ngh = ngh;
            DisplayData();
        }

        private void DisplayData()
        {
            cbxTime.Text = "Sáng";
            lbMaVX.Visible = false;
            lbGiaVX.Visible = false;

            radioBut9Thang.Visible = false;
            radioBut12Thang.Visible = false;
            radioBut24Thang.Visible = false;
            lbNgayTiemGoiLe.Visible = false;
            lbNgayTiemPN.Visible = false;
            lbNgayTiemTre.Visible = false;
            lbTenVX.Visible = false;
            cbxTenVX.Visible = false;
            dtpkGoiLe.Visible = false;
            dtpkGoiPhuNu.Visible = false;
            dtpkGoiTre.Visible = false;
            panelGio.Visible = false;

            _vx = VacXinBUS.GetlistVacXin();
            cbxTenVX.DataSource = _vx;
            cbxTenVX.DisplayMember = "Ten";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_ngh.HoTen != "" && _kh.MaNguoiGiamHo == "Không có")
            {
                NguoiGiamHoBUS.addNGH(_ngh);
                KhachHangBUS.CapNhatMaNGH(_ngh.MaNGH, _kh.MaKH);
                _kh.MaNguoiGiamHo = _ngh.MaNGH;
            }

            PhieuDangKy pdk = new PhieuDangKy("", DateTime.Now.ToString(), 0, 0);
            PhieuDangKyBUS.addPDK(pdk, _kh);

            double tongtien = 0;
            bool failedGoiLe = false, failedGoiPhuNu = false, failedGoiTre = false;

            if (checkGoiTre.Checked)
            {
                //chon goi tre
                if (radioBut9Thang.Checked)
                {
                    if (PhieuDangKyBUS.DangKyGoiVX(pdk.MaPhieu, "MG1", dtpkGoiTre.Text, "gói cho trẻ 9 tháng tuổi"))
                    {
                        tongtien = tongtien + PhieuDangKyBUS.getGiaGoiVXByMaGoi("MG1");
                        MessageBox.Show("Đăng ký thành công gói cho trẻ 9 tháng");
                    }
                    else
                    {
                        failedGoiTre = true;
                        MessageBox.Show("Đăng ký thất bại gói cho trẻ 9 tháng");
                    }
                }
                else if (radioBut12Thang.Checked)
                {

                    if (PhieuDangKyBUS.DangKyGoiVX(pdk.MaPhieu, "MG2", dtpkGoiTre.Text, "gói cho trẻ 12 tháng tuổi"))
                    {
                        tongtien = tongtien + PhieuDangKyBUS.getGiaGoiVXByMaGoi("MG2");
                        MessageBox.Show("Đăng ký thành công cho gói cho trẻ 12 tháng");
                    }
                    else
                    {
                        failedGoiTre = true;
                        MessageBox.Show("Đăng ký thất bại gói cho trẻ 12 tháng");
                    }
                }
                else if (radioBut24Thang.Checked)
                {

                    if (PhieuDangKyBUS.DangKyGoiVX(pdk.MaPhieu, "MG3", dtpkGoiTre.Text, "gói cho trẻ 24 tháng tuổi"))
                    {
                        tongtien = tongtien + PhieuDangKyBUS.getGiaGoiVXByMaGoi("MG3");
                        MessageBox.Show("Đăng ký thành công gói cho trẻ 24 tháng");
                    }
                    else
                    {
                        failedGoiTre = true;
                        MessageBox.Show("Đăng ký thất bại gói cho trẻ 24 tháng");
                    }
                }
            }

            if (checkGoiPhuNu.Checked)
            {

                if (PhieuDangKyBUS.DangKyGoiVX(pdk.MaPhieu, "MG4", dtpkGoiPhuNu.Text, "gói phụ nữ mang thai"))
                {
                    tongtien = tongtien + PhieuDangKyBUS.getGiaGoiVXByMaGoi("MG4");
                    MessageBox.Show("Đăng ký thành công gói cho phụ nữ mang thai");
                }
                else
                {
                    failedGoiPhuNu = true;
                    MessageBox.Show("Đăng ký thất bại gói cho phụ nữ mang thai");
                }
            }

            if (checkGoiLe.Checked)
            {
                if (PhieuDangKyBUS.DangKyVacXin(pdk.MaPhieu, lbMaVX.Text, dtpkGoiLe.Text, cbxTime.Text))
                {
                    tongtien = tongtien + Convert.ToDouble(lbGiaVX.Text);
                    MessageBox.Show("Đăng ký thành công gói lẻ");
                }
                else
                {
                    failedGoiLe = true;
                    MessageBox.Show("Đăng ký thất bại gói lẻ");
                }
            }

            if (!failedGoiLe || !failedGoiPhuNu || !failedGoiTre)
            {
                MessageBox.Show("Đăng ký tiêm chủng thành công vui lòng thanh toán");
                PhieuDangKyBUS.CapNhatTongTien(pdk.MaPhieu, tongtien);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký tiêm chủng thất bại");
            }

            PhieuDangKyBUS.deletePDK(pdk.MaPhieu);
            if (checkGoiTre.Checked == false && checkGoiPhuNu.Checked == false && checkGoiLe.Checked == false)
            {
                MessageBox.Show("Bạn chưa đăng ký vắc-xin");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(KhachHangBUS.CalculateAge(_kh.NgaySinh) >= 18)
            {
                PhieuDangKyTiemChungForm PDKTC = new PhieuDangKyTiemChungForm(_kh);
                PDKTC.ShowDialog();
            }
            else
            {
                ThongTinNguoiGiamHoForm TTNGH = new ThongTinNguoiGiamHoForm(_kh, _ngh);
                TTNGH.ShowDialog();
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy phiếu đăng ký không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btnXemCTGVX_Click(object sender, EventArgs e)
        {
            ChiTietGoiVacXinForm CTGVX = new ChiTietGoiVacXinForm();
            CTGVX.ShowDialog();
        }

        private void cbxTenVX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null) return;

            VacXin selected = cb.SelectedItem as VacXin;

            lbMaVX.Text = selected.MaVX;
            lbGiaVX.Text = selected.GiaVX.ToString();
        }

        private void checkGoiTre_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGoiTre.Checked)
            {
                radioBut9Thang.Visible = true;
                radioBut12Thang.Visible = true;
                radioBut24Thang.Visible = true;
                lbNgayTiemTre.Visible = true;
                dtpkGoiTre.Visible = true;

            }
            else
            {
                radioBut9Thang.Visible = false;
                radioBut12Thang.Visible = false;
                radioBut24Thang.Visible = false;
                lbNgayTiemTre.Visible = false;
                dtpkGoiTre.Visible = false;
            }
        }

        private void checkGoiPhuNu_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGoiPhuNu.Checked)
            {
                lbNgayTiemPN.Visible = true;
                dtpkGoiPhuNu.Visible = true;
            }
            else
            {
                lbNgayTiemPN.Visible = false;
                dtpkGoiPhuNu.Visible = false;
            }
        }

        private void checkGoiLe_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGoiLe.Checked)
            {
                lbNgayTiemGoiLe.Visible = true;
                dtpkGoiLe.Visible = true;
                lbTenVX.Visible = true;
                cbxTenVX.Visible = true;
                panelGio.Visible = true;
            }
            else
            {
                lbNgayTiemGoiLe.Visible = false;
                dtpkGoiLe.Visible = false;
                lbTenVX.Visible = false;
                cbxTenVX.Visible = false;
                panelGio.Visible = false;
            }
        }
    }
}

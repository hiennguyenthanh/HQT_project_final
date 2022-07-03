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
    public partial class HoaDonForm : Form
    {
        private KhachHang _kh;
        private HoaDonPhieuDangKy _hd;
        private List<HoaDonPhieuDangKy> _listHdpdk;
        // private List<HoaDonPhieuDatMua> _listHdpdm;
        private bool _check = false;
        public HoaDonForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
            LoadData();
        }

        private void LoadData()
        {
            lbHoTen.Text = _kh.Hoten;
            lbMaKH.Text = _kh.MaKH;
            _listHdpdk = HoaDonPhieuDangKyBUS.DisplayDetail(_kh.MaKH, true);
        }

        private void DisplayData(List<HoaDonPhieuDangKy> list)
        {

            dtgvHoaDonPDK.Rows.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgvHoaDonPDK);

                row.Cells[0].Value = list[i].MaHDPDK;
                row.Cells[1].Value = list[i].MaPDK;

                row.Cells[2].Value = list[i].NgayLap;
                row.Cells[3].Value = list[i].NgayTra;
                row.Cells[4].Value = list[i].LaiSuat;
                row.Cells[5].Value = list[i].TongTien;
                // 0: chưa thanh toán, 1: đã thanh toán
                if (Convert.ToBoolean(list[i].TrangThai))
                {
                    row.Cells[6].Value = "Đã thanh toán";
                }
                else
                {
                    row.Cells[6].Value = "Chưa thanh toán";
                }

                row.Cells[7].Value = list[i].MoTa;
                dtgvHoaDonPDK.Rows.Add(row);
            }
        }

        private void btnHoaDonPhieuDangKy_Click(object sender, EventArgs e)
        {
            _check = false;
            if (_listHdpdk.Count == 0)
                MessageBox.Show("Bạn không có hóa đơn đăng ký tiêm chủng nào!");
            else
                DisplayData(_listHdpdk);
        }

        private void dtgvHoaDonPDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHoaDonPDK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvHoaDonPDK.CurrentRow.Selected = true;
                string str = dtgvHoaDonPDK.Rows[e.RowIndex].Cells["TrangThai"].FormattedValue.ToString();
                if (str == "Chưa thanh toán")
                {
                    string mahdpdk = dtgvHoaDonPDK.Rows[e.RowIndex].Cells["MaHDPDK"].FormattedValue.ToString();
                    _hd = HoaDonPhieuDangKyBUS.getHoaDonPDK(_kh, mahdpdk);
                    btnThanhToan.Enabled = true;
                }
                if (str == "Đã thanh toán")
                {
                    string mahdpdk = dtgvHoaDonPDK.Rows[e.RowIndex].Cells["MaHDPDK"].FormattedValue.ToString();
                    _hd = HoaDonPhieuDangKyBUS.getHoaDonPDK(_kh, mahdpdk);
                    btnThanhToan.Enabled = false;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanForm TT = new ThanhToanForm(_kh, _hd);
            TT.ShowDialog();
            LoadData();
            if (_check)
            {
                // DisplayData(_listGoiDacBiet);
            }
            else
            {
                DisplayData(_listHdpdk);
            }
        }
    }
}

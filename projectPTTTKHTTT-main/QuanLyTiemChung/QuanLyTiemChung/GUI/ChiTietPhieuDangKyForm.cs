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
    public partial class ChiTietPhieuDangKyForm : Form
    {
        private KhachHang _kh;

        private List<ChiTietPhieuDangKy> _listGoiLe;
        private List<ChiTietPhieuDangKy> _listGoiDacBiet;

        private string mapdk = " ";
        private bool _check = false;

        public ChiTietPhieuDangKyForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
            LoadData();
        }

        private void LoadData()
        {
            lbMaKH.Text = _kh.MaKH;
            lbHoTen.Text = _kh.Hoten;
            _listGoiDacBiet = PhieuDangKyBUS.DisplayDetail(_kh.MaKH, true);
            _listGoiLe = PhieuDangKyBUS.DisplayDetail(_kh.MaKH, false);
        }

        private void DisplayData(List<ChiTietPhieuDangKy>list)
        {

            dtgvChiTietPDK.Rows.Clear();

            for(int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgvChiTietPDK);

                row.Cells[0].Value = list[i].MaPhieu;
                row.Cells[1].Value = list[i].NgayLap;
                row.Cells[2].Value = list[i].TenGoi;
                row.Cells[3].Value = list[i].TenVX;
                row.Cells[4].Value = list[i].NgayTiem;
                row.Cells[5].Value = list[i].GioTiem;
                row.Cells[6].Value = list[i].TrangThai;

                dtgvChiTietPDK.Rows.Add(row);
            }
        }

        private void btnGoiDacBiet_Click(object sender, EventArgs e)
        {
            _check = false;
            if (_listGoiDacBiet.Count == 0)
                MessageBox.Show("Bạn không có đăng ký gói đặc biệt");
            else
                DisplayData(_listGoiDacBiet);
        }

        private void btnGoiLe_Click(object sender, EventArgs e)
        {
            _check = true;
            if (_listGoiLe.Count == 0)
                MessageBox.Show("Bạn không có đăng ký gói lẻ");
            else
                DisplayData(_listGoiLe);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvChiTietPDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvChiTietPDK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvChiTietPDK.CurrentRow.Selected = true;
                string str = dtgvChiTietPDK.Rows[e.RowIndex].Cells["TrangThai"].FormattedValue.ToString();
                if (str == "Chưa xuất hóa đơn")
                {
                    mapdk = dtgvChiTietPDK.Rows[e.RowIndex].Cells["MaPhieu"].FormattedValue.ToString();
                    btnXuatHoaDon.Enabled = true;
                }
                if (str == "Đã xuất hóa đơn")
                {
                    mapdk = dtgvChiTietPDK.Rows[e.RowIndex].Cells["MaPhieu"].FormattedValue.ToString();
                    btnXuatHoaDon.Enabled = false;
                }
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            SelectThanhToan STT = new SelectThanhToan(_kh, mapdk);
            STT.ShowDialog();
            LoadData();
            if (!_check)
            {
                DisplayData(_listGoiDacBiet);
            }
            else
            {
                DisplayData(_listGoiLe);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class PhieuDangKy
    {
        private string _MaPhieu;
        private string _NgayLap;
        private double _TongTien;
        private int _TrangThai;

        public PhieuDangKy(string maPhieu, string ngayLap, double tongTien, int trangThai)
        {
            this._MaPhieu = maPhieu;
            this._NgayLap = ngayLap;
            this._TongTien = tongTien;
            this._TrangThai = trangThai;
        }

        public PhieuDangKy(DataRow row)
        {
            this._MaPhieu = row["MaPhieu"].ToString();
            this._NgayLap = row["NgayLap"].ToString();
            this._TongTien = Convert.ToDouble(row["TongTien"]);
            if (Convert.ToBoolean(row["TrangThai"].ToString()))
            {
                this._TrangThai = 1; // đã xuất đơn
            }
            else
            {
                this._TrangThai = 0; // chưa xuất đơn
            }
        }

        public string MaPhieu { get => _MaPhieu; set => _MaPhieu = value; }
        public string NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public double TongTien { get => _TongTien; set => _TongTien = value; }
        public int TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}

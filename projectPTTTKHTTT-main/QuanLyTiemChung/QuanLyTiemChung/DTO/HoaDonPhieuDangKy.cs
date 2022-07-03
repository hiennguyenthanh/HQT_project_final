using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class HoaDonPhieuDangKy
    {
        private string _MaHDPDK;
        private string _MaPDK;
        private string _NgayLap;
        private double _TongTien;
        private int _TrangThai;
        private string _NgayTra;
        private double _LaiSuat;
        private string _STK;
        private string _Mota;

        public HoaDonPhieuDangKy(string maPhieu, string maPdk, string ngayLap, double tongTien, int trangThai,
            string ngayTra, double laiSuat, string stk, string mota)
        {
            this._MaHDPDK = maPhieu;
            this._MaPDK = maPdk;
            this._NgayLap = ngayLap;
            this._TongTien = tongTien;
            this._TrangThai = trangThai;
            this._NgayTra = ngayTra;
            this._LaiSuat = laiSuat;
            this._STK = stk;
            this._Mota = mota;
        }

        public HoaDonPhieuDangKy(DataRow row)
        {
            this._MaHDPDK = row["MaHDPDK"].ToString();
            this._NgayLap = row["NgayLap"].ToString();
            this._MaPDK = row["MaPDK"].ToString();
            if (Convert.ToBoolean(row["TrangThai"]))
            {
                this._TrangThai = 1;
            }
            else
            {
                this._TrangThai = 0;
            }

            if (row["NgayTra"] == DBNull.Value)
            {
                this._NgayTra = "---";
            }
            else
            {
                this._NgayTra = row["NgayTra"].ToString();
            }

            this._TongTien = Convert.ToDouble(row["TongTien"]);
            this._LaiSuat = Convert.ToDouble(row["LaiSuat"]);
            if (row["SoTaiKhoan"] == DBNull.Value)
            {
                this._STK = "---";
            }
            else
            {
                this._STK = row["SoTaiKhoan"].ToString();

            }
            if (row["Mota"] == DBNull.Value)
            {
                this._Mota = "---";
            }
            else
            {
                this._Mota = row["Mota"].ToString();

            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string MaHDPDK
        {
            get => _MaHDPDK;
            set => _MaHDPDK = value;
        }

        public string MaPDK
        {
            get => _MaPDK;
            set => _MaPDK = value;
        }
        public double LaiSuat
        {
            get => _LaiSuat;
            set => _LaiSuat = value;
        }

        public string NgayLap
        {
            get => _NgayLap;
            set => _NgayLap = value;
        }

        public double TongTien
        {
            get => _TongTien;
            set => _TongTien = value;
        }

        public int TrangThai
        {
            get => _TrangThai;
            set => _TrangThai = value;
        }

        public string NgayTra
        {
            get => _NgayTra;
            set => _NgayTra = value;
        }
        public string STK
        {
            get => _STK;
            set => _STK = value;
        }

        public string MoTa
        {
            get => _Mota;
            set => _Mota = value;
        }
    }
}

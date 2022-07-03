using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung
{
    public class HoaDonPhieuDatMua
    {
        private string _MaHDPDM;
        private string _NgayLap;
        private double _TongTien;
        private string _TrangThai;
        private string _NgayTra;
        private double _LaiSuat;


        public HoaDonPhieuDatMua(string maPhieu, string ngayLap, double tongTien, string trangThai, string ngayTra, double laiSuat)
        {
            this._MaHDPDM = maPhieu;
            this._NgayLap = ngayLap;
            this._TongTien = tongTien;
            this._TrangThai = trangThai;
            this._NgayTra = ngayTra;
            this._LaiSuat = laiSuat;
        }

        public string MaPhieu
        {
            get => _MaHDPDM;
            set => _MaHDPDM = value;
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

        public string TrangThai
        {
            get => _TrangThai;
            set => _TrangThai = value;
        }

        public string NgayTra
        {
            get => _NgayTra;
            set => _NgayTra = value;
        }
    }
}

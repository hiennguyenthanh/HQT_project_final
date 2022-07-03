using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class ChiTietHoaDonPDK
    {
        private string _MaHDPDK;
        private string _MaPDK;
        private string _MaVX;
        private string _Ten;
        private string _MaNCC;
        private double _GiaVX;

        public ChiTietHoaDonPDK(DataRow row)
        {
            this._MaHDPDK = row["MaHDPDK"].ToString();
            this._MaPDK = row["MaPDK"].ToString();
            this._MaVX = row["MaVX"].ToString();
            this._Ten = row["Ten"].ToString();
            if (row["MaNCC"] == DBNull.Value)
            {
                this._MaNCC = "---";
            }
            else
            {
                this._MaNCC = row["NgayTra"].ToString();
            }
            this._GiaVX = Convert.ToDouble(row["GiaVX"]);

        }

        public string MaHDPDK { get => _MaHDPDK; set => _MaHDPDK = value; }
        public string MaPDK { get => _MaPDK; set => _MaPDK = value; }
        public string MaVX { get => _MaVX; set => _MaVX = value; }
        public string TenVX { get => _Ten; set => _Ten = value; }
        public string NCC { get => _MaNCC; set => _MaNCC = value; }
        public double Gia { get => _GiaVX; set => _GiaVX = value; }
    }
}

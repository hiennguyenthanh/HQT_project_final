using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class SoTaiKhoan
    {
        private string _SoTK;
        private double _SoDu;
        private string _NganHang;

        public SoTaiKhoan(string soTk, double soDu, string nganHang) =>
            (_SoTK, _SoDu, _NganHang) = (soTk, soDu, nganHang);

        public SoTaiKhoan(DataRow row)
        {
            this._SoTK = row["SoTK"].ToString();
            this._SoDu = Convert.ToDouble(row["SoDu"]);
            this._NganHang = row["NganHang"].ToString();
        }
        public string SoTK { get => _SoTK; set => _SoTK = value; }
        public double SoDu { get => _SoDu; set => _SoDu = value; }
        public string NganHang { get => _NganHang; set => _NganHang = value; }
    }
}

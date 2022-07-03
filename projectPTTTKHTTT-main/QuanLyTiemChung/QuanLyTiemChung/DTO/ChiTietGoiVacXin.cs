using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class ChiTietGoiVacXin
    {
        private string _MaGoi;
        private string _TenGoi;
        private string _MaVX;
        private string _TenVX;
        private int _SLVX;
        private string _GioTiem;
        private double _Gia;
        public ChiTietGoiVacXin(DataRow row)
        {
            this._MaGoi = row["MaGoi"].ToString();
            this._TenGoi = row["TenGoi"].ToString();
            this._MaVX = row["MaVX"].ToString();
            this._TenVX = row["TenVX"].ToString();
            this._SLVX = Convert.ToInt32(row["SLVX"].ToString());
            this._GioTiem = row["TGTiem"].ToString();
            this._Gia = Convert.ToDouble(row["Gia"].ToString());
        }
        public string MaGoi { get => _MaGoi; set => _MaGoi = value; }
        public string TenGoi { get => _TenGoi; set => _TenGoi = value; }
        public string MaVX { get => _MaVX; set => _MaVX = value; }
        public string TenVX { get => _TenVX; set => _TenVX = value; }
        public int SLVX { get => _SLVX; set => _SLVX = value; }
        public string GioTiem { get => _GioTiem; set => _GioTiem = value; }
        public double Gia { get => _Gia; set => _Gia = value; }
    }
}

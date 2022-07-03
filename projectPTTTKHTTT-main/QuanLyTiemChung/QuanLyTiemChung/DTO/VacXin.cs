using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyTiemChung
{
    public class VacXin
    {
        private string _MaVX;
        private string _Ten;
        private string _MaNCC;
        private double _GiaVX;
        private int _SoLuongTon;

        public VacXin(string maVX, string ten, string maNCC, double giaVX, int Soluong)
        {
            this._MaVX = maVX;
            this._Ten = ten;
            this._MaNCC = maNCC;
            this._GiaVX = giaVX;
            this._SoLuongTon = Soluong;
        }

        public VacXin(DataRow row)
        {
            this._MaVX = row["MaVX"].ToString();
            this._Ten = row["Ten"].ToString();
            this._MaNCC = row["MaNCC"].ToString();
            this._GiaVX = Convert.ToDouble(row["GiaVX"].ToString());
            this._SoLuongTon = Convert.ToInt32(row["SoLuongTon"].ToString());
        }
       
        public string MaVX { get => _MaVX; set => _MaVX = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public double GiaVX { get => _GiaVX; set => _GiaVX = value; }
        public int SoLuongTon { get => _SoLuongTon; set => _SoLuongTon = value; }
    }
}

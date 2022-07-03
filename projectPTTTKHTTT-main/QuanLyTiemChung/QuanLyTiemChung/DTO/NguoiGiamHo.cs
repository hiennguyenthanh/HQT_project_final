using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class NguoiGiamHo
    {
        private string _MaNGH;
        private string _Hoten;
        private string _NgaySinh;
        private string _SoCMND;
        private string _SoDT;
        private string _DiaChi;
        private string _GioiTinh;

        public NguoiGiamHo(string maNGH, string hoten, string ngaySinh, string soCMND, string soDT, string diachi, string gioitinh)
        {
            this._MaNGH = maNGH;
            this._Hoten = hoten;
            this._NgaySinh = ngaySinh;
            this._SoCMND = soCMND;
            this._SoDT = soDT;
            this._DiaChi = diachi;
            this._GioiTinh = gioitinh;
        }

        public NguoiGiamHo(DataRow row)
        {
            this._MaNGH = row["MaNguoiGiamHo"].ToString();
            this._Hoten = row["HoTen"].ToString();
            this._NgaySinh = row["NgaySinh"].ToString();
            this._SoCMND = row["SoCMND"].ToString();
            this._SoDT = row["SoDT"].ToString();
            this._DiaChi = row["DiaChi"].ToString();
            this._GioiTinh = row["GioiTinh"].ToString(); 
        }

        public string MaNGH { get => _MaNGH; set => _MaNGH = value; }
        public string HoTen { get => _Hoten; set => _Hoten = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SoCMND { get => _SoCMND; set => _SoCMND = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
    }
}

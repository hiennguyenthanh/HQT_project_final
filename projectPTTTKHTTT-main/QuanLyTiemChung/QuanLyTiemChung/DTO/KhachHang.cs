using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class KhachHang
    {
        private string _MaKH;
        private string _Hoten;
        private string _NgaySinh;
        private string _SoCMND;
        private string _SoDT;
        private string _DiaChi;
        private string _Email;
        private string _MatKhau;
        private string _GioiTinh;
        private string _MaNguoiGiamHo;
        private string _BHYT;

        public KhachHang(DataRow row)
        {
            this._MaKH = row["MaKH"].ToString();
            this._Hoten = row["HoTen"].ToString();
            this._NgaySinh = row["NgaySinh"].ToString();
            this._SoDT = row["SoDT"].ToString();
            this._DiaChi = row["DiaChi"].ToString();
            this._Email = row["Email"].ToString();
            this._MatKhau = row["MatKhau"].ToString();
            this._GioiTinh = row["GioiTinh"].ToString();

            string manguoigiamho = ""; 
            string bhyt = "";
            string cmnd = "";

            if (row["SoCMND"].ToString() == "")
                cmnd = "Không có";
            else
                cmnd = row["SoCMND"].ToString();

            if (row["MaNguoiGiamHo"].ToString() == "")
                manguoigiamho = "Không có";
            else
                manguoigiamho = row["MaNguoiGiamHo"].ToString();

            if (row["soBHYT"].ToString() == "")
                bhyt = "Không có";
            else
                bhyt = row["soBHYT"].ToString();

            this._SoCMND = cmnd;
            this._MaNguoiGiamHo = manguoigiamho;
            this._BHYT = bhyt;
        }

        public KhachHang(string maKH, string hoten, string ngaySinh, string soCMND, string soDT, string diaChi, string email, string matKhau, string gioitinh, string manguoigiamho, string bhyt)
        {
            this._MaKH = maKH;
            this._Hoten = hoten;
            this._NgaySinh = ngaySinh;
            this._SoDT = soDT;
            this._DiaChi = diaChi;
            this._Email = email;
            this._MatKhau = matKhau;
            this._GioiTinh = gioitinh;

            if (soCMND == "")
                soCMND = "Không có";
            if (manguoigiamho == "")
                manguoigiamho = "Không có";
            if (bhyt == "")
                bhyt = "Không có";

            this._SoCMND = soCMND;
            this._MaNguoiGiamHo = manguoigiamho;
            this._BHYT = bhyt;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string Hoten { get => _Hoten; set => _Hoten = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SoCMND { get => _SoCMND; set => _SoCMND = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value;  }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string MaNguoiGiamHo { get => _MaNguoiGiamHo; set => _MaNguoiGiamHo = value; }
        public string BHYT { get => _BHYT; set => _BHYT = value; }
    }
}

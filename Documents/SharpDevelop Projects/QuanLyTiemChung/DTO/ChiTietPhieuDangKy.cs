using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class ChiTietPhieuDangKy
    {
        private string _MaPhieu;
        private string _NgayLap;
        private string _TenGoi;
        private string _TenVX;
        private string _NgayTiem;
        private string _GioTiem;
        private string _TrangThai;

        public ChiTietPhieuDangKy(DataRow row)
        {
            this._MaPhieu = row["MaPhieu"].ToString();
            this._NgayLap = row["NgayLap"].ToString();
            this._TenGoi = row["TenGoi"].ToString();
            this._TenVX = row["TenVX"].ToString();
            this._NgayTiem = row["NgayTiem"].ToString();
            this._GioTiem = row["TGTiem"].ToString();
            string TrangThai = "Chưa thanh toán";

            if (Convert.ToBoolean(row["TrangThai"].ToString()))
                TrangThai = "Đã thanh toán";
            this._TrangThai = TrangThai;
        }
        
        public string MaPhieu { get => _MaPhieu; set => _MaPhieu = value; }
        public string NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public string TenGoi { get => _TenGoi; set => _TenGoi = value; }
        public string TenVX { get => _TenVX; set => _TenVX = value; }
        public string NgayTiem { get => _NgayTiem; set => _NgayTiem = value;  }
        public string GioTiem { get => _GioTiem; set => _GioTiem = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}

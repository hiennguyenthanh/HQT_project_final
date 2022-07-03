using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class HoaDonPhieuDangKyDAO
    {
        public static List<HoaDonPhieuDangKy> DisplayDetail(string MaKH, bool type)
        {
            string query = "select hd.MaHDPDK,hd.MaPDK , hd.NgayLap, hd.NgayTra, hd.TrangThai, hd.TongTien, hd.SoTaiKhoan, hd.LaiSuat, hd.Mota from HoaDonPhieuDangKy hd where MaKhachHang='" + MaKH + "' ORDER BY NgayLap ASC, MoTa";

            List<HoaDonPhieuDangKy> list = new List<HoaDonPhieuDangKy>();
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HoaDonPhieuDangKy(row));
            }
            return list;
        }

        // public static bool addHoaDonPDK( KhachHang kh,PhieuDangKy pdk)
        // {
        //     string query = "update PhieuDangKy set MaKH = '" + kh.MaKH + "', NgayLap = '"+pdk.NgayLap+"', TrangThai = "+pdk.TrangThai.ToString()+" where MaPhieu = '"+pdk.MaPhieu+"'";
        //     int successfulRow = DataProvider.ExecuteNonQuery(query);
        //     return successfulRow > 0;
        // }

        public static HoaDonPhieuDangKy getHoaDonPDK(KhachHang kh, string MaHDPDK)
        {
            string query = "select * from HoaDonPhieuDangKy where MaHDPDK ='" + MaHDPDK + "' and MaKhachHang = '" + kh.MaKH + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return new HoaDonPhieuDangKy(dt.Rows[0]);
        }

        public static bool addID()
        {
            string query = "exec spThemIDHDPDK";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
        public static string getID()
        {
            string query = "select MaHDPDK from HoaDonPhieuDangKy where MaKhachHang is null";
            DataTable dt = DataProvider.ExecuteQuery(query);
            string IDHD = dt.Rows[0][0].ToString();
            return IDHD;
        }
        public static bool addHD(KhachHang kh, HoaDonPhieuDangKy hd)
        {
            string query = "update HoaDonPhieuDangKy set MaKhachHang = '" + kh.MaKH + "', NgayLap = '" + hd.NgayLap + "',LaiSuat = 0.028, MaPDK='" + hd.MaPDK + "', TrangThai = " + hd.TrangThai + ", MoTa = N'" + hd.MoTa + "' where MaHDPDK = '" + hd.MaHDPDK + "'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;

        }

        public static List<ChiTietHoaDonPDK> DisplayDetail()
        {
            List<ChiTietHoaDonPDK> list = new List<ChiTietHoaDonPDK>();
            // string query = "select gvx.MaGoi, gvx.TenGoi, vx.MaVX, vx.Ten as TenVX, ctgvx.SoLuongVacXin as SLVX, ctgvx.ThoiGianTiem as TGTiem, gvx.Gia " +
            //                "from GoiVacXin gvx join ChiTietGoiVX ctgvx on gvx.MaGoi = ctgvx.MaGoi join VacXin vx on ctgvx.MaVX = vx.MaVX";
            // DataTable dt = DataProvider.ExecuteQuery(query);
            // foreach(DataRow row in dt.Rows)
            // {
            //     list.Add(new ChiTietGoiVacXin(row));
            // }
            return list;
        }

        public static bool CapNhatTinhTrang(string MaHD)
        {
            string query = "update HoaDonPhieuDangKy set TrangThai = 1 where MaHDPDK = '" + MaHD + "'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

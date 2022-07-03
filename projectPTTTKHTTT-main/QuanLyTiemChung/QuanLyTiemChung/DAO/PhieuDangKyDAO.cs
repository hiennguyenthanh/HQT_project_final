using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class PhieuDangKyDAO
    {
        public static List<ChiTietPhieuDangKy>DisplayDetail(string MaKH, bool type)
        {
            string query = "select pdk.MaPhieu, pdk.NgayLap, N'Gói lẻ' as TenGoi, vx.Ten as TenVX, dkvx.NgayTiem, dkvx.TGTiem, pdk.TrangThai " +
                "from PhieuDangKy pdk join DangKyVacXin dkvx on pdk.MaPhieu = dkvx.MaPhieu " +
                "join VacXin vx on dkvx.MaVX = vx.MaVX where pdk.MaKH = '" + MaKH + "'";
            if (type)
                query = "select pdk.MaPhieu, pdk.NgayLap, gvx.TenGoi, vx.Ten as TenVX, dkgvx.NgayTiem, ct.ThoiGianTiem as TGTiem, pdk.TrangThai " +
                    "from PhieuDangKy pdk join DangKyGoiVacXin dkgvx on pdk.MaPhieu = dkgvx.MaPhieu " +
                    "join ChiTietGoiVX ct on dkgvx.MaGoi = ct.MaGoi " +
                    "join GoiVacXin gvx on dkgvx.MaGoi = gvx.MaGoi " +
                    "join VacXin vx on ct.MaVX = vx.MaVX " +
                    "where pdk.MaKH = '" + MaKH + "'";

            List<ChiTietPhieuDangKy> list = new List<ChiTietPhieuDangKy>();
            DataTable dt = DataProvider.ExecuteQuery(query);

            foreach(DataRow row in dt.Rows)
            {
                list.Add(new ChiTietPhieuDangKy(row));
            }
            return list;
        }

        public static bool addIDPDK()
        {
            string query = "exec spThemIDPDK";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static string getIDPDK()
        {
            string query = "select MaPhieu from PhieuDangKy where MaKH is null";
            DataTable dt = DataProvider.ExecuteQuery(query);
            string IDPDK = dt.Rows[0][0].ToString();
            return IDPDK;
        }

        public static bool addPDK(PhieuDangKy pdk, KhachHang kh)
        {
            string query = "update PhieuDangKy set MaKH = '" + kh.MaKH + "', NgayLap = '"+pdk.NgayLap+"', TrangThai = "+pdk.TrangThai.ToString()+" where MaPhieu = '"+pdk.MaPhieu+"'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static bool DangKyGoiVX(string MaPhieu, string MaGoi, string NgayTiem)
        {   
            string query = "insert DangKyGoiVacXin values('" + MaPhieu + "', '" + MaGoi + "', '" + NgayTiem + "')";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static bool DangKyVacXin(string MaPhieu, string MaVX, string NgayTiem, string GioTiem)
        {
            string query = "insert DangKyVacXin values('" + MaPhieu + "', '" + MaVX + "', '" + NgayTiem + "', '"+ GioTiem +"')";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static bool CapNhatTongTien(string MaPhieu, double TongTien)
        {
            string query = "update PhieuDangKy set TongTien = " + TongTien.ToString() + " where MaPhieu = '"+MaPhieu+"'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static bool deletePDK(string MaPhieu)
        {
            string query = "delete from PhieuDangKy where MaPhieu = '"+MaPhieu+"' and TongTien is null";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        //---------------------------------Hiền----------------
        public static PhieuDangKy getPhieuDangKy(KhachHang kh, string MaPhieu)
        {
            string query = "select * from PhieuDangKy where MaPhieu ='" + MaPhieu + "' and MaKH = '" + kh.MaKH + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return new PhieuDangKy(dt.Rows[0]);
        }

        public static int getTongTien(KhachHang kh, string MaPhieu)
        {
            string query = "select TongTien from PhieuDangKy where MaPhieu='" + MaPhieu + "' and MaKH='" + kh.MaKH +
                           "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static bool CapNhatTinhTrang(string MaPhieu)
        {
            string query = "update PhieuDangKy set TrangThai = 1 where MaPhieu = '" + MaPhieu + "'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

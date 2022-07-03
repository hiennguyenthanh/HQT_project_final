using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyTiemChung
{
    public class SoTaiKhoanDAO
    {
        public static List<SoTaiKhoan> GetlistSTK(string MaKH)
        {
            List<SoTaiKhoan> list = new List<SoTaiKhoan>();
            string query = "select * from SoTaiKhoan where MaKhachHang='" + MaKH + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SoTaiKhoan(row));
            }
            return list;
        }

        public static SoTaiKhoan GetSTK(string SoTK, string NganHang)
        {
            string query = "select * from SoTaiKhoan where SoTK ='" + SoTK + "' and NganHang = '" + NganHang + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return new SoTaiKhoan(dt.Rows[0]);
        }

        public static double GetSoDu(string SoTK, string NganHang)
        {
            string query = "select SoDU from SoTaiKhoan where SoTK ='" + SoTK + "' and NganHang = '" + NganHang + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            return Convert.ToDouble(dt.Rows[0][0]);
        }

        public static bool TruTien(string SoTK, string NganHang, double SoTien)
        {
            string query = "update SoTaiKhoan set SoDu = SoDu - " + SoTien.ToString() + " where SoTK = '" + SoTK + "' and NganHang='" + NganHang + "'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

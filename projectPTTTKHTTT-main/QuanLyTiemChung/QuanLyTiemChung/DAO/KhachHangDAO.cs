using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public class KhachHangDAO
    {
        public static bool addIDKH()
        {
            string query = "exec spThemIDKH";
            int successfulRows = DataProvider.ExecuteNonQuery(query);
            return successfulRows > 0;
        }

        public static bool addKH(KhachHang kh, string ID, string hashPass)
        {

            string query = "update KhachHang set HoTen = N'"+ kh.Hoten +"', NgaySinh = '"+ kh.NgaySinh +"', SoCMND = '" + kh.SoCMND + "', SoDT = '"+ kh.SoDT + "', " +
                "DiaChi = N'"+ kh.DiaChi + "', Email = '"+ kh.Email + "', MatKhau = '"+ hashPass +"', GioiTinh = N'"+ kh.GioiTinh + "' " +
                "where MaKH = '"+ ID + "'";

            int successfulRows = DataProvider.ExecuteNonQuery(query);
            return successfulRows > 0;
        }

        public static bool getEmail(string email)
        {
            string query = string.Format("select * from KhachHang where Email = '{0}'", email);
            return DataProvider.ExecuteQuery(query).Rows.Count > 0;
        }

        public static string getIDKH()
        {
            string query = "select MaKH from KhachHang where Email is null";
            string IDKH = DataProvider.ExecuteQuery(query).Rows[0][0].ToString();
            return IDKH;
        }

        public static List<KhachHang>getKhachHangByEmailAndPass(string email, string pass)
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "select * from KhachHang kh left join BHYT b on kh.MaKH = b.MaKH where kh.Email = '"+email+"' and kh.MatKhau = '"+ pass +"'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new KhachHang(row));
            }
            return list;
        }

        public static bool CapNhatMaNGH(string MaNGH, string MaKH)
        {
            string query = "update KhachHang set MaNguoiGiamHo = '"+MaNGH+"' where MaKH = '"+MaKH+"'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

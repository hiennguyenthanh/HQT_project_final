using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class NguoiGiamHoDAO
    {
        public static List<NguoiGiamHo>GetNguoiGiamByMaKH(string MaKH)
        {
            List<NguoiGiamHo> list = new List<NguoiGiamHo>();
            string query = "select ngh.MaNguoiGiamHo, ngh.HoTen, ngh.NgaySinh, ngh.SoCMND, ngh.SoDT, ngh.DiaChi, ngh.GioiTinh " +
                "from KhachHang kh join NguoiGiamHo ngh on kh.MaNguoiGiamHo = ngh.MaNguoiGiamHo " +
                "where kh.MaKH = '"+ MaKH +"'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new NguoiGiamHo(row));
            }
            return list;
        }

        public static bool addIDNGH()
        {
            string query = "exec spThemIDNGH";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static string getIDNGH()
        {
            string query = "select MaNguoiGiamHo from NguoiGiamHo where SoCMND is null";
            string IDNGH = DataProvider.ExecuteQuery(query).Rows[0][0].ToString();
            return IDNGH;
        }

        public static bool addNGH(NguoiGiamHo ngh)
        {
            string query = "update NguoiGiamHo set HoTen = N'" + ngh.HoTen+"', NgaySinh = '"+ngh.NgaySinh+"', " +
                "SoCMND = '"+ngh.SoCMND+"', SoDT = '"+ngh.SoDT+"', " +
                "DiaChi = N'"+ngh.DiaChi+"', GioiTinh = N'"+ngh.GioiTinh+"' " +
                "where MaNguoiGiamHo = '"+ngh.MaNGH+"'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class NguoiGiamHoBUS
    {
        public static List<NguoiGiamHo>GetNguoiGiamHoByMaKH(string MaKH)
        {
            return NguoiGiamHoDAO.GetNguoiGiamByMaKH(MaKH);
        }

        public static int CalculateAge(string NgaySinh)
        {
            DateTime CurDate = DateTime.Now;
            DateTime NSinh = Convert.ToDateTime(NgaySinh);
            int age = CurDate.Year - NSinh.Year;
            return age;
        }

        public static bool addNGH(NguoiGiamHo ngh)
        {
            bool addID = NguoiGiamHoDAO.addIDNGH();
            if (!addID) return false;
            string ID = NguoiGiamHoDAO.getIDNGH();
            ngh.MaNGH = ID;
            return NguoiGiamHoDAO.addNGH(ngh);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung
{
    public class SoTaiKhoanBUS
    {
        public static List<SoTaiKhoan> GetlistSTK(string MaKH)
        {
            return SoTaiKhoanDAO.GetlistSTK(MaKH);
        }
        public static SoTaiKhoan GetSTK(string SoTK, string NganHang)
        {
            return SoTaiKhoanDAO.GetSTK(SoTK, NganHang);
        }

        public static bool KiemTraSoDu(SoTaiKhoan STK, double soTien)
        {
            if (SoTaiKhoanDAO.GetSoDu(STK.SoTK, STK.NganHang) >= soTien)
            {
                SoTaiKhoanDAO.TruTien(STK.SoTK, STK.NganHang, soTien);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

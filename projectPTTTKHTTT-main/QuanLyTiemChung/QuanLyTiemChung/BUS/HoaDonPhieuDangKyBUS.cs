using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung
{
    public class HoaDonPhieuDangKyBUS
    {
        public static List<HoaDonPhieuDangKy> DisplayDetail(string MaKH, bool type)
        {
            List<HoaDonPhieuDangKy> list = HoaDonPhieuDangKyDAO.DisplayDetail(MaKH, type);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].NgayTra != "---")
                {
                    DateTime DTimeNgayTra = Convert.ToDateTime(list[i].NgayTra);
                    list[i].NgayTra = DTimeNgayTra.ToString("dd/MM/yyyy HH:mm");
                }
                DateTime DTimeNgayLap = Convert.ToDateTime(list[i].NgayLap);
                list[i].NgayLap = DTimeNgayLap.ToString("dd/MM/yyyy HH:mm");
            }
            return list;
        }

        public static bool addHoaDonPDK(KhachHang kh, HoaDonPhieuDangKy hd)
        {
            bool addID = HoaDonPhieuDangKyDAO.addID();
            if (!addID) return false;
            string ID = HoaDonPhieuDangKyDAO.getID();
            hd.MaHDPDK = ID;
            return HoaDonPhieuDangKyDAO.addHD(kh, hd);
        }
        public static HoaDonPhieuDangKy getHoaDonPDK(KhachHang kh, string mahd)
        {
            return HoaDonPhieuDangKyDAO.getHoaDonPDK(kh, mahd);
        }

        public static bool CapNhatTinhTrang(string MaPhieu)
        {
            return HoaDonPhieuDangKyDAO.CapNhatTinhTrang(MaPhieu);
        }
    }
}

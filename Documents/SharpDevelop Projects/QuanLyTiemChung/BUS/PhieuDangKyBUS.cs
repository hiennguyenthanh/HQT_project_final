using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung
{
    public class PhieuDangKyBUS
    {
        public static List<ChiTietPhieuDangKy>DisplayDetail(string MaKH, bool type)
        {
            List<ChiTietPhieuDangKy>list = PhieuDangKyDAO.DisplayDetail(MaKH, type);
            for(int i = 0; i < list.Count; i++)
            {
                DateTime DTimeNgayLap = Convert.ToDateTime(list[i].NgayLap);
                DateTime DTimeNgayTiem = Convert.ToDateTime(list[i].NgayTiem);

                list[i].NgayLap = DTimeNgayLap.ToString("yyyy-MM-dd");
                list[i].NgayTiem = DTimeNgayTiem.ToString("yyyy-MM-dd");
            }
            return list;
        }
    }
}

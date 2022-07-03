using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung
{
    class GoiVacXinBUS
    {
        public static List<ChiTietGoiVacXin> DisplayDetail()
        {
            List<ChiTietGoiVacXin> list = GoiVacXinDAO.DisplayDetail();
            for(int i = 0; i < list.Count; i++)
            {
                DateTime DTime = Convert.ToDateTime(list[i].GioTiem);
                list[i].GioTiem = DTime.ToString("HH:mm");
            }
            return list;
        }
    }
}

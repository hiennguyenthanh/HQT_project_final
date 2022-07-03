using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung
{
    public class VacXinBUS
    {
        public static List<VacXin>GetlistVacXin()
        {
            List<VacXin>vx = VacXinDAO.GetlistVacXin();
            List<VacXin> Newvx = new List<VacXin>();
            for(int i = 0; i < vx.Count; i++)
            {
                if (vx[i].SoLuongTon > 0)
                    Newvx.Add(vx[i]);
            }
            return Newvx;
        }
    }
}

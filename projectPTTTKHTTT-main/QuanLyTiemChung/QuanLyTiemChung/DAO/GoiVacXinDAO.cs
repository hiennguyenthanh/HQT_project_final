using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyTiemChung
{
    public class GoiVacXinDAO
    {
        public static List<ChiTietGoiVacXin>DisplayDetail()
        {
            List<ChiTietGoiVacXin> list = new List<ChiTietGoiVacXin>();
            string query = "select gvx.MaGoi, gvx.TenGoi, vx.MaVX, vx.Ten as TenVX, ctgvx.SoLuongVacXin as SLVX, ctgvx.ThoiGianTiem as TGTiem, gvx.Gia " +
                "from GoiVacXin gvx join ChiTietGoiVX ctgvx on gvx.MaGoi = ctgvx.MaGoi join VacXin vx on ctgvx.MaVX = vx.MaVX";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new ChiTietGoiVacXin(row));
            }
            return list;
        }
    }
}

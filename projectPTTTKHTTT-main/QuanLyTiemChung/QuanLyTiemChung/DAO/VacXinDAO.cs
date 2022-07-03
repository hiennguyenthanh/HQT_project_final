using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyTiemChung
{
    public class VacXinDAO
    {
        public static List<VacXin>GetlistVacXin()
        {
            List<VacXin> list = new List<VacXin>();
            string query = "select * from VacXin";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new VacXin(row));
            }
            return list;
        }

        public static bool CapNhatSoLuong(string MaVX, int SoLuongMua)
        {
            string query = "update VacXin set SoLuongTon = SoLuongTon - "+SoLuongMua.ToString()+" where MaVX = '"+MaVX+"'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

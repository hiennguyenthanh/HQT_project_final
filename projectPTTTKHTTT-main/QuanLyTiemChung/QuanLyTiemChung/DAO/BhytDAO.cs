using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyTiemChung
{
    public class BhytDAO
    {
        public static List<Bhyt>GetBHYTByID(string soBHYT)
        {
            List<Bhyt> list = new List<Bhyt>();
            string query = "select * from BHYT where soBHYT = '"+ soBHYT +"'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new Bhyt(row));
            }
            return list;
        }

        public static bool AddBHYT(Bhyt bhyt, KhachHang kh)
        {
            string query = "insert BHYT values('"+bhyt.SoBHYT+"', '"+kh.MaKH+"', '"+bhyt.NgayHH+"')";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }

        public static bool UpdateBHYT(Bhyt bhyt)
        {
            string query = "update BHYT set NgayHetHan = '" + bhyt.NgayHH + "' where soBHYT = '"+bhyt.SoBHYT+"'";
            int successfulRow = DataProvider.ExecuteNonQuery(query);
            return successfulRow > 0;
        }
    }
}

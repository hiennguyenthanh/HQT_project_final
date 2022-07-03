using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class BhytBUS
    {
        public static List<Bhyt>GetBHYTByID(string MaKH)
        {
            return BhytDAO.GetBHYTByID(MaKH);
        }

        public static bool OutOfDate(Bhyt bhyt)
        {
            DateTime CurDate = DateTime.Now;
            DateTime NgayHH = Convert.ToDateTime(bhyt.NgayHH);
            int check = DateTime.Compare(CurDate, NgayHH);

            return check <= 0; // curdate <= NgayHH
        }


        public static bool UpdateBHYT(Bhyt bhyt, KhachHang kh)
        {
            bool isOutOfDate = OutOfDate(bhyt);
            if (!isOutOfDate) { MessageBox.Show("BHYT đã hết hạn"); return false; }
            if (kh.BHYT == "")
            {
                MessageBox.Show("Mã BHYT không hợp lệ");
                return false;
            }
            else if (kh.BHYT == "Không có" || bhyt.SoBHYT != kh.BHYT)
            {
                List<Bhyt> list = BhytDAO.GetBHYTByID(bhyt.SoBHYT);
                if(list.Count > 0)
                {
                    MessageBox.Show("Mã BHYT đã tồn tại");
                    return false;
                }
                kh.BHYT = bhyt.SoBHYT;
                return BhytDAO.AddBHYT(bhyt, kh);
            }
            else
            {
                return BhytDAO.UpdateBHYT(bhyt);
            }
        }
    }
}

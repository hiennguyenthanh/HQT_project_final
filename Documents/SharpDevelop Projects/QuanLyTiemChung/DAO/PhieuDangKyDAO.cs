using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public class PhieuDangKyDAO
    {
        public static List<ChiTietPhieuDangKy>DisplayDetail(string MaKH, bool type)
        {
            string query = "select pdk.MaPhieu, pdk.NgayLap, N'Gói lẻ' as TenGoi, vx.Ten as TenVX, dkvx.NgayTiem, dkvx.TGTiem, pdk.TrangThai " +
                "from PhieuDangKy pdk join DangKyVacXin dkvx on pdk.MaPhieu = dkvx.MaPhieu " +
                "join VacXin vx on dkvx.MaVX = vx.MaVX where pdk.MaKH = '" + MaKH + "'";
            if (type)
                query = "select pdk.MaPhieu, pdk.NgayLap, gvx.TenGoi, vx.Ten as TenVX, dkgvx.NgayTiem, ct.ThoiGianTiem as TGTiem, pdk.TrangThai " +
                    "from PhieuDangKy pdk join DangKyGoiVacXin dkgvx on pdk.MaPhieu = dkgvx.MaPhieu " +
                    "join ChiTietGoiVX ct on dkgvx.MaGoi = ct.MaGoi " +
                    "join GoiVacXin gvx on dkgvx.MaGoi = gvx.MaGoi " +
                    "join VacXin vx on ct.MaVX = vx.MaVX " +
                    "where pdk.MaKH = '" + MaKH + "'";

            List<ChiTietPhieuDangKy> list = new List<ChiTietPhieuDangKy>();
            DataTable dt = DataProvider.ExecuteQuery(query);

            foreach(DataRow row in dt.Rows)
            {
                list.Add(new ChiTietPhieuDangKy(row));
            }
            return list;
        }
    }
}

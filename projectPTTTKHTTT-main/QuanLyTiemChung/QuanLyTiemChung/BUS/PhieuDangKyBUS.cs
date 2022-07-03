using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                DateTime time = Convert.ToDateTime(list[i].GioTiem);
                list[i].NgayLap = DTimeNgayLap.ToString("dd/MM/yyyy");
                list[i].NgayTiem = DTimeNgayTiem.ToString("dd/MM/yyyy");
                list[i].GioTiem = time.ToString("HH:mm");
            }
            return list;
        }

        public static bool addPDK(PhieuDangKy pdk, KhachHang kh)
        {
            bool addID = PhieuDangKyDAO.addIDPDK();
            if (!addID) return false;
            string ID = PhieuDangKyDAO.getIDPDK();
            pdk.MaPhieu = ID;
            return PhieuDangKyDAO.addPDK(pdk, kh);
        }

        public static List<VacXin>getVacXinByMaGoi(string MaGoi)
        {
            List<ChiTietGoiVacXin> listCTGVX = GoiVacXinDAO.DisplayDetail();

            List<VacXin> VxTrongGoi = new List<VacXin>();
            for (int i = 0; i < listCTGVX.Count; i++)
            {
                if (listCTGVX[i].MaGoi == MaGoi)
                {
                    VxTrongGoi.Add(new VacXin(listCTGVX[i].MaVX, listCTGVX[i].TenVX, "", listCTGVX[i].Gia, listCTGVX[i].SLVX));
                }
            }
            return VxTrongGoi;
        }

        public static double getGiaGoiVXByMaGoi(string MaGoi)
        {
            List<ChiTietGoiVacXin> listCTGVX = GoiVacXinDAO.DisplayDetail();

            List<VacXin> VxTrongGoi = new List<VacXin>();
            for (int i = 0; i < listCTGVX.Count; i++)
            {
                if (listCTGVX[i].MaGoi == MaGoi)
                {
                    VxTrongGoi.Add(new VacXin(listCTGVX[i].MaVX, listCTGVX[i].TenVX, "", listCTGVX[i].Gia, listCTGVX[i].SLVX));
                }
            }
            return VxTrongGoi[0].GiaVX;
        }

        public static bool KiemTraSoLuongVX(List<VacXin>VxTrongGoi, List<VacXin>listVX)
        {
            for (int i = 0; i < VxTrongGoi.Count; i++)
            {
                for(int j = 0; j < listVX.Count; j++)
                {
                    if(VxTrongGoi[i].MaVX == listVX[j].MaVX && VxTrongGoi[i].SoLuongTon > listVX[i].SoLuongTon)
                    {
                        MessageBox.Show("Hết vắc-xin " + VxTrongGoi[i].Ten + " vui lòng đặt mua vắc-xin");
                        return false;
                    }
                    else if(VxTrongGoi[i].MaVX == listVX[j].MaVX && VxTrongGoi[i].SoLuongTon <= listVX[i].SoLuongTon)
                    {
                        VacXinDAO.CapNhatSoLuong(VxTrongGoi[i].MaVX, VxTrongGoi[i].SoLuongTon);
                    }
                }
            }
            return true;
        }

        public static bool DangKyGoiVX(string MaPhieu, string MaGoi, string NgayTiem, string TenGoi)
        {

            List<VacXin> listVX = VacXinDAO.GetlistVacXin();
            List<VacXin> VacXinTrongGoi = getVacXinByMaGoi(MaGoi);

            bool kiemtra = KiemTraSoLuongVX(VacXinTrongGoi, listVX);

            if (!kiemtra) 
            {
                MessageBox.Show("Hết "+TenGoi + "");
                return false;
            }

            if (PhieuDangKyDAO.DangKyGoiVX(MaPhieu, MaGoi, NgayTiem))
            {
                return true;
            }
            return false;
        }

        public static bool DangKyVacXin(string MaPhieu, string MaVX, string NgayTiem, string GioTiem)
        {
            string temp = "9:00";
            if (GioTiem == "Chiều")
                temp = "14:00";
            if (PhieuDangKyDAO.DangKyVacXin(MaPhieu, MaVX, NgayTiem, temp))
            {
                if (VacXinDAO.CapNhatSoLuong(MaVX, 1))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool deletePDK(string MaPhieu)
        {
            return PhieuDangKyDAO.deletePDK(MaPhieu);
        }
        public static bool CapNhatTongTien(string MaPhieu, double TongTien)
        {
            return PhieuDangKyDAO.CapNhatTongTien(MaPhieu, TongTien);
        }

        //-----------------------Hiền----------------------
        public static PhieuDangKy getPhieuDangKy(KhachHang kh, string MaPhieu)
        {
            return PhieuDangKyDAO.getPhieuDangKy(kh, MaPhieu);
        }

        public static int KiemtraTongTien(KhachHang kh, string MaPhieu)
        {
            if (PhieuDangKyDAO.getTongTien(kh, MaPhieu) < 1500000)
            {
                return 1;
            }
            if (PhieuDangKyDAO.getTongTien(kh, MaPhieu) < 3000000)
            {
                return 2;
            }
            if (PhieuDangKyDAO.getTongTien(kh, MaPhieu) < 4500000)
            {
                return 3;
            }
            if (PhieuDangKyDAO.getTongTien(kh, MaPhieu) < 6000000)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public static bool CapNhatTinhTrang(string MaPhieu)
        {
            return PhieuDangKyDAO.CapNhatTinhTrang(MaPhieu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;

namespace QuanLyTiemChung
{
    class KhachHangBUS
    {
        public static string HashPass(string PassBeforeHash)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(PassBeforeHash);
            byte[] hashdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach (byte item in hashdata)
            {
                hashPass += item;
            }
            return hashPass;
        }

        public static int CalculateAge(string NgaySinh)
        {
            DateTime CurDate = DateTime.Now;
            DateTime NSinh = Convert.ToDateTime(NgaySinh);
            int age = CurDate.Year - NSinh.Year;
            return age;
        }
        public static bool Register(KhachHang kh)
        {
            int age = CalculateAge(kh.NgaySinh);

            if (age >= 16 && kh.SoCMND == "Không có")
            {
                MessageBox.Show("Chưa nhập CMND");
                return false;
            }

            bool isExistedEmail = KhachHangDAO.getEmail(kh.Email);
            if (isExistedEmail) 
            {
                MessageBox.Show("Email đã tồn tại");
                return false;
            }

            bool addID = KhachHangDAO.addIDKH();
            if (!addID) return false;

            string IDKH = KhachHangDAO.getIDKH();

            string hashPass = HashPass(kh.MatKhau);


            bool addNewKH = KhachHangDAO.addKH(kh, IDKH, hashPass);
            if (!addNewKH) return false; 

            kh.MaKH = IDKH;
            DateTime NSinh = Convert.ToDateTime(kh.NgaySinh);
            kh.NgaySinh = NSinh.ToString("dd/MM/yyyy");

            return true;
        }

        public static List<KhachHang> Login(string email, string password)
        {
            string hashPass = HashPass(password);
            List<KhachHang> kh = KhachHangDAO.getKhachHangByEmailAndPass(email, hashPass);
            if(kh.Count > 0)
            {
                DateTime NSinh = Convert.ToDateTime(kh[0].NgaySinh);
                kh[0].NgaySinh = NSinh.ToString("dd/MM/yyyy");
            }
            return kh;
        }

        public static bool CapNhatMaNGH(string MaNGH, string MaKH)
        {
            return KhachHangDAO.CapNhatMaNGH(MaNGH, MaKH);
        }
    }
}

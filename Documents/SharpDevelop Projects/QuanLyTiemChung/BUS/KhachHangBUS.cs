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

        public static bool Register(KhachHang kh)
        {
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
            return true;
        }

        public static List<KhachHang> Login(string email, string password)
        {
            string hashPass = HashPass(password);
            List<KhachHang> kh = KhachHangDAO.getKhachHangByEmailAndPass(email, hashPass);
            return kh;
        }
    }
}

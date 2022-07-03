using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(radioButKhachHang.Checked)
            {
                List <KhachHang> list_kh = KhachHangBUS.Login(txtboxEmail.Text, txtboxPassword.Text);
                if(list_kh.Count <= 0)
                    MessageBox.Show("Nhập sai email hoặc mật khẩu");
                else
                {
                    list_kh[0].MatKhau = txtboxPassword.Text;
                    this.Hide();
                    HomeKhachHangForm home = new HomeKhachHangForm(list_kh[0]);
                    home.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnDangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}

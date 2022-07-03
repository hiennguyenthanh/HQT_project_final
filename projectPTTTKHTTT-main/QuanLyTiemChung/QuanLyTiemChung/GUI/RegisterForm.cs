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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cbxGioiTinh.Text = "Nam";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(radioButKhachHang.Checked)
            {
                string gioitinh = cbxGioiTinh.Text;

                KhachHang kh = new KhachHang("", txbHoTen.Text, dtpkNgaySinh.Text, txbCMND.Text, txbDienThoai.Text, txbDiaChi.Text, txbEmail.Text, "", gioitinh, "", "");
                this.Hide();
                EnterPassForm EP = new EnterPassForm(kh);
                EP.ShowDialog();
                this.Close();
            }
            else // đăng ký cho nhân viên
            {

            }
        }

        private void btnDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}

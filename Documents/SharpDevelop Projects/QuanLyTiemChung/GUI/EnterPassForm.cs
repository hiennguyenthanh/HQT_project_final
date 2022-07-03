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
    public partial class EnterPassForm : Form
    {
        private KhachHang _kh;

        public EnterPassForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
        }
       
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "" || txbXacNhanMatKhau.Text == "")
                MessageBox.Show("Chưa nhập hoặc xác nhận mật khẩu");
            else if (txbMatKhau.Text != txbXacNhanMatKhau.Text)
                MessageBox.Show("Mật khẩu xác nhận chưa trùng khớp");
            else
            {
                _kh.MatKhau = txbMatKhau.Text;
                if (KhachHangBUS.Register(_kh))
                {
                    MessageBox.Show("Đăng ký thành công");

                    this.Hide();
                    HomeKhachHangForm home = new HomeKhachHangForm(_kh);
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy đăng ký không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                RegisterForm registerForm = new RegisterForm();
                registerForm.ShowDialog();
                this.Close();
            }
        }
    }
}

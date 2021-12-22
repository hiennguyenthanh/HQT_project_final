using Delivery.DAO;
using Delivery.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public partial class fLogin : Form
    {
        private string userID;
        private string Role;
        private string status;
        public fLogin()
        {
            InitializeComponent();
            LoadRole();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
        private void LoadRole()
        {
            cbRole.Items.Add("Tài xế");
            cbRole.Items.Add("Khách hàng");
            cbRole.Items.Add("Nhân viên");
            cbRole.SelectedIndex = 0;
        }


        //private void btnDangNhap_Click(object sender, EventArgs e)
        //{
        //    //fNhanVien f = new fNhanVien();
        //    this.Hide();
        //   // f.ShowDialog();
        //    this.Show();
        //}

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // fSignUp f = new fSignUp();
            this.Hide();
          //  f.ShowDialog();
            this.Show();
        }

        private void labelDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
        //sự kiện link đăng ký
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fSignUp f = new fSignUp();
            f.ShowDialog();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Role = cbRole.SelectedItem.ToString();
            string loginname = txtLoginUserName.Text;
            string pass = txtLoginPass.Text;
            //lấy id người dùng thừ db dựa vào tên đăng nhập
            string[] info = AccountDAO.Instance.Login(loginname, pass);
            if (info.Length == 0)
            {
                MessageBox.Show("Không thể đăng nhập");
            }
            else
            {
                if (info[1] == "0") //tài khoản bị khóa
                {
                    MessageBox.Show("Tài khoản bị khóa");
                }
                else
                {
                    if (info[1] == "2")
                    {
                        MessageBox.Show("Tài khoản đang chờ duyệt");
                    }
                    else //tài khoản hợp lệ
                    {
                        //kiểm tra vai trò của id
                        userID = info[0];
                        OpenUIUser(userID);
                       
                    }
                }
            }

        }

        private void OpenUIUser(string id)
        {
            Form userForm;
            if (id.Contains("TX") && Role=="Tài xế")
            {
                this.Hide();
                userForm = new MainTX(id);
                userForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                if (id.Length != 0)
                {
                    MessageBox.Show("Đang cập nhật");
                }
                
            }
        }
    }
}

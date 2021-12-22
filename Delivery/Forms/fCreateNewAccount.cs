using Delivery.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.Forms
{
    public partial class fCreateNewAccount : Form
    {
        private string UserRole;
        private string userName;
        private string pass;
            
        public fCreateNewAccount(string role)
        {
            InitializeComponent();
            this.UserRole = role;
            LoadRole(this.UserRole);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //gán giá trị để hiện thị vai trò
        private void LoadRole(string role)
        {
            txtChoosenRole.Text = role;
            if (role=="Khách hàng")
            {
                panelSignUpFee.Visible = false;
                txtnBankAccount.Enabled = false;
            }
        }

        private void btnCancelSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //khi chọn nút đăng kí thì thêm tài khoản tương ứng với vai trò
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool r=false;
            int flag = 0;
            userName = txtSignUpLoginName.Text;
            pass = txtSignUpPass.Text;
            string retype = txtSignUpRetypePass.Text;
            string bank = "";
            if (txtnBankAccount.Enabled == false)
            {
                bank = "1";
            }
            else
            {
                bank = txtnBankAccount.Text;
            }
            
            if (userName=="" || pass=="" || retype == "" || bank=="")
            {
                MessageBox.Show("Không thể để trống");

            }
            else
            {
                if (pass != retype)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
                else
                {
                    //insert
                    //kiểm tra user có bị trùng
                    DataTable table = DataProvider.Instance.ExecuteQuery1("select UserID FROM TAIKHOAN");
                    foreach (DataRow row in table.Rows)
                    {
                        string temp = row["UserID"].ToString();
                        if (temp == userName)
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại");
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0) //nếu không tồn tại tài khoản trong db thì insert
                    {
                        r = AccountDAO.Instance.InsertAccount(userName, pass, UserRole);
                    }
                   
                }
            }
            if (r)
            {
                
                this.Dispose();
                this.Hide();

                //thực hiện đăng nhập
                Form form = new fLogin();
                MessageBox.Show("Tạo tài khoản thành công");
                form.ShowDialog();
                List<Form> list = new List<Form>();
                foreach (Form f in Application.OpenForms)
                {
                    list.Add(f);
                }
                foreach (Form f in list)
                {
                    if (f.Name != "fLogin")
                    {
                        f.Close();
                    }
                }

            }
            else
            {

                this.Dispose();
                this.Hide();

                //thực hiện đăng nhập
                Form form = new fLogin();
                MessageBox.Show("Tạo tài khoản thất bại");
                form.ShowDialog();
                List<Form> list = new List<Form>();
                foreach (Form f in Application.OpenForms)
                {
                    list.Add(f);
                }
                foreach (Form f in list)
                {
                    if (f.Name != "fLogin")
                    {
                        f.Close();
                    }
                }

               

            }
            
        }
    }
}

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
    public partial class fSignUp : Form
    {
        private Form activeForm;
        private string choosenRole;
        public fSignUp()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //hùy thì trở về màn hình đăng nhập
        private void btnCancelSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f = new fLogin();
            f.ShowDialog();
            
        }
        private void OpenChildUserSignUp(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
           
            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelSignUpDesktop.Controls.Add(childform);
            this.panelSignUpDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();

            
            btnCancelSignUp.Enabled = false;
            btnChooseRole.Enabled = false;
        }

        //click chọn xác nhận thì hiện childform tương ứng với từng vai trò
        private void btnChooseRole_Click(object sender, EventArgs e)
        {
            if (rdCustomer.Checked == true)
            {
                choosenRole = rdCustomer.Text;
                rdDriver.Enabled = false;
                rdStaff.Enabled = false;
            }
            else
            {
                if (rdDriver.Checked == true)
                {
                    choosenRole = rdDriver.Text;
                    rdCustomer.Enabled = true;
                    rdStaff.Enabled = false;
                }
                else
                {
                    choosenRole = rdStaff.Text;
                    rdCustomer.Enabled = false;
                    rdDriver.Enabled = false;
                }
            }

            btnCancelChildForm.Visible = true;
            OpenChildUserSignUp(new Forms.fCreateNewAccount(choosenRole));
            
        }

        private void btnCancelChildForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form f = new fLogin();
            f.ShowDialog();
            
        }
        
    }
}

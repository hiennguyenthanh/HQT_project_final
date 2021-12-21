using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HeThongVanChuyen
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.pnSignUp.Hide();
            this.pnChonLoaiUser.Show();
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.pnChonLoaiUser.Hide();
            this.pnSignUp.Show();
        }

        private void btnQuayLai_ChonLoaiUser_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


    }
}

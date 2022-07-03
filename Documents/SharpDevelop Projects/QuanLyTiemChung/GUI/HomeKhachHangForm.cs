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
    public partial class HomeKhachHangForm : Form
    {
        private KhachHang _kh;
        private Button currentBtn;
        public HomeKhachHangForm(KhachHang kh)
        {
            InitializeComponent();
            _kh = kh;
            btnThongTinCaNhan.Text = _kh.Hoten;
        }

        private void openChildForm(object sender, Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_body.Controls.Add(childForm);
            this.panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                if (currentBtn != null)
                    currentBtn.BackColor = Color.FromArgb(80, 62, 90);

                currentBtn = (Button)sender;
                currentBtn.BackColor = Color.FromArgb(122, 133, 224);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(sender, new SelectionForm(_kh));
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(sender, new InformationForm(_kh));
        }
    }
}

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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            this.Hide();
            nv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoiTac dt = new DoiTac();
            this.Hide();
            dt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaiXe tx = new TaiXe();
            this.Hide();
            tx.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            this.Hide();
            kh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            this.Hide();
            hd.ShowDialog();
        }
    }
}

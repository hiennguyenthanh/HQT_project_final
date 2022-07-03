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
    public partial class ChiTietGoiVacXinForm : Form
    {
        public ChiTietGoiVacXinForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            List<ChiTietGoiVacXin> list = GoiVacXinBUS.DisplayDetail();
            dtgvChiTietGVX.Rows.Clear();
            for(int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgvChiTietGVX);
                row.Cells[0].Value = list[i].MaGoi;
                row.Cells[1].Value = list[i].TenGoi;
                row.Cells[2].Value = list[i].TenVX;
                row.Cells[3].Value = list[i].SLVX.ToString();
                row.Cells[4].Value = list[i].GioTiem;
                row.Cells[5].Value = list[i].Gia.ToString();
                dtgvChiTietGVX.Rows.Add(row);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

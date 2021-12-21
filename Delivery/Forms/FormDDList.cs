﻿using Delivery.DAO;
using Delivery.DTO;
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
    public partial class FormDDList : Form
    {
        private Form activeForm;
        public FormDDList()
        {
            InitializeComponent();
            LoadListByID("TX1");
        }


        void LoadListByID(string id)
        {
            //gridNotDone.DataSource = OrderDAO.Instance.GetListOrderById(id);
            List<Order> list = new List<Order>();
            list = OrderDAO.Instance.GetListOrderByAreaOfDriver(id);
            if (list.Count == 0)
            {
                Console.WriteLine("list null");
            }
            else
            {
                Console.WriteLine("list not null" + list.Count.ToString());
            }
            int length = list.Count();
            int i = 0;
            while (i < length)
            {
                string mahd = (string)list[i].ID1;
                string tinhtrang = (string)list[i].Status1;
                string diachi = (string)list[i].OAddr1;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(gridAllOrder);
                newrow.Cells[0].Value = mahd.ToUpper();
                newrow.Cells[1].Value = tinhtrang;
                newrow.Cells[2].Value = diachi;
                gridAllOrder.Rows.Add(newrow);
                i++;
            }

            //hiện khu vực hoạt động
            string area = "";
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExecuteQuery1("select * from TAIXE where MaTX = '" + id + "'");
            foreach (DataRow row in table.Rows)
            {
                Driver d = new Driver(row);
                area = d.Area1;
            }
            btnAreaAll.Text = area;

        }
        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void gridAllOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row=gridAllOrder.Rows[index];
            string MADH = row.Cells[0].Value.ToString();
            MessageBox.Show("lấy thành công " + MADH);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new Forms.FormDetailedOrder());
        }

        private void btnScrollNotDone_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }
        //private void OpenChildForm(Form childform)
        //{

        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    //highlight button chosen
           
        //    activeForm = childform;
        //    activeForm.TopLevel = false;
        //    childform.FormBorderStyle = FormBorderStyle.None;
        //    childform.Dock = DockStyle.Fill;
        //    this.panelListOrderDesktop.Controls.Add(childform);
        //    this.panelListOrderDesktop.Tag = childform;
        //    childform.BringToFront();
        //    childform.Show();
            
        //}
    }
}

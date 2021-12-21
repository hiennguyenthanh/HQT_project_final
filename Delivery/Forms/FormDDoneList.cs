using Delivery.DAO;
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
    public partial class FormDDoneList : Form
    {
        private string UserID;

        public FormDDoneList(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
            LoadDoneListByID(this.UserID);
        }

        private void btnScrollNotDone_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }
        void LoadDoneListByID(string id)
        {
            //gridNotDone.DataSource = OrderDAO.Instance.GetListOrderById(id);
            List<Order> list = new List<Order>();
            list = OrderDAO.Instance.GetListDoneOrderById(id);
            int length = list.Count();
            int i = 0;
            while (i < length)
            {
                string mahd = (string)list[i].ID1;
                string tinhtrang = (string)list[i].Status1;
                string diachi = (string)list[i].OAddr1;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(gridDone);
                newrow.Cells[0].Value = mahd.ToUpper();
                newrow.Cells[1].Value = tinhtrang;
                newrow.Cells[2].Value = diachi;
                gridDone.Rows.Add(newrow);
                i++;
            }

            

        }
    }
}

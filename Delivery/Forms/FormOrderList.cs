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
    public partial class FormOrderList : Form
    {
        private Form activeForm;
        private string UserID;
        public FormOrderList(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
            LoadListByArea(this.UserID);
        }
        private void OpenChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //xóa giao diện cũ trên panel 
            panelOrderDesktop.Controls.Clear();
            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelOrderDesktop.Controls.Add(childform);
            this.panelOrderDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            
        }

        void LoadListByArea(string id)
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
                newrow.CreateCells(gridOrder);
                newrow.Cells[0].Value = mahd.ToUpper();
                newrow.Cells[1].Value = tinhtrang;
                newrow.Cells[2].Value = diachi;
                gridOrder.Rows.Add(newrow);
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
            btnAreaOrder.Text = area;

        }

     

        private void gridOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = gridOrder.Rows[index];
            string MADH = row.Cells[0].Value.ToString();
            OpenChildForm(new FormDetailedOrder(this.UserID,MADH));
        }
    }
    
}

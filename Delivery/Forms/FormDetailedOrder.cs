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
    public partial class FormDetailedOrder : Form
    {
        private string UserID;
        public FormDetailedOrder(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
            LoadInfoChoosenOrder(this.UserID);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadInfoChoosenOrder(string id)
        {
            Order order = OrderDAO.Instance.GetOrder(id);
            txtDOrderID.Text = order.ID1;
            txtDCusID.Text = order.CusID1;
            txtDMethod.Text = order.Method1;
            txtDShipFee.Text = order.ShipFee1.ToString();
            txtDOrderTime.Text = order.TimeOrder1.ToString("MM/dd/yyyy");
            string temp = order.OAddr1;
            string[] listAddr1 = temp.Split(',');
            string no = listAddr1[0].Trim();
            string street = listAddr1[1].Trim();
            string ward = listAddr1[2].Trim();
            string district = listAddr1[3].Trim();
            string city = listAddr1[4].Trim();
            txtDOrderNo.Text = no;
            txtDOrderStreet.Text = street;
            txtDOrderWard.Text = ward;
            txtDOrderDistrict.Text = district;
            txtDOrderCity.Text = city;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDMethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDChooseOrder_Click(object sender, EventArgs e)
        {
            string MADH = txtDOrderID.Text;
            string MATX = this.UserID;
            bool result = DriverDAO.Instance.UpdateChoosenOrder(MADH,MATX);
            if (result)
            {
                MessageBox.Show("Chọn đơn hàng thành công");
            }
            else
            {
                MessageBox.Show("Chọn đơn hàng thất bại");
            }
            this.Dispose();
        }
    }
}

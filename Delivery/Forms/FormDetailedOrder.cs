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
        private string OrderID;
        public FormDetailedOrder(string userid,string orderid)
        {
            InitializeComponent();
            this.UserID = userid;
            this.OrderID = orderid;
            LoadInfoChoosenOrder(this.OrderID);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadInfoChoosenOrder(string id)
        {
            try
            {
                Order order = OrderDAO.Instance.GetOrder(id);
                txtDOrderID.Text = order.ID1;
                txtDCusID.Text = order.CusID1;
                txtDMethod.Text = order.Method1;
                txtDShipFee.Text = order.ShipFee1.ToString();
                float receivedFee = (float)(0.3 * order.ShipFee1);
                //tiền phí mà tài xế nhận được
                txtDReceivedFee.Text = receivedFee.ToString();
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
            catch(Exception e)
            {
                Console.WriteLine("exception: " + e.Message);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDMethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDChooseOrder_Click(object sender, EventArgs e)
        {
           string MADH = this.OrderID;
            string MATX = this.UserID;
            //thêm mã tài xế vào đơn hàng đã chọn
            int result = DriverDAO.Instance.UpdateChoosenOrder(MADH,MATX);
            if (result>0)
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

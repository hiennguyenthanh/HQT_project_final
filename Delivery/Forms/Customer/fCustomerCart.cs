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

namespace Delivery.Forms.Customer
{
    public partial class fCustomerCart : Form
    {
        private string CusID;
        private float totalPrice;
        public fCustomerCart(string cusid)
        {
            InitializeComponent();
            this.CusID = cusid;
            LoadTempOrder();
            LoadComboBoxMethod();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadTempOrder()
        {
            List<DetailedOrder> list = Global.listDetail;
            int length = Global.listDetail.Count;
            int i = 0;
            while (i < length)
            {
                string masp = (string)list[i].ProductId1;
                string tensp = (string)list[i].ProductName1;
                float gia = (float)list[i].Price1;
                int soluong = (int)list[i].Quality1;
                float total = soluong * gia;

                //them gia vao list
                list[i].TotalPrice1 = total;

                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(gridNotBuy);
                newrow.Cells[0].Value = masp.ToUpper();
                newrow.Cells[1].Value = tensp;
                newrow.Cells[2].Value = gia.ToString();
                newrow.Cells[3].Value = soluong.ToString();
                newrow.Cells[4].Value = total.ToString();
                gridNotBuy.Rows.Add(newrow);
                i++;
            }
        }
        

        private void gridNotBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            float total;
            string temp = txtTotalOrder.Text.ToString();
            if (temp == "")
            {
                txtTotalOrder.Text = "0";
                total = 0;
            }
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                gridNotBuy.CommitEdit(DataGridViewDataErrorContexts.Commit);

                if ((bool)gridNotBuy.CurrentCell.Value == true)
                {
                    //nếu đã click checkbox thì cập nhật total
                    DataGridViewRow row = gridNotBuy.Rows[e.RowIndex];
                    total = float.Parse(row.Cells[4].Value.ToString());
                   // MessageBox.Show(row.Cells[4].Value.ToString());
                    this.totalPrice += total;
                    txtTotalOrder.Text = this.totalPrice.ToString();
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int result;
            //insert bill
            DetailedOrder detail = new DetailedOrder();
            float fee = float.Parse(txtShipFee.Text);
            string method = cbMethod.SelectedItem.ToString();
            string status = "Đang chuẩn bị hàng";
            DateTime date = datepickerOrder.Value;
            if (method == "")
            {
                
            }
            string newid = OrderDAO.Instance.InsertOrder(CusID, status, method, fee, date);
            MessageBox.Show(newid);
            foreach (DataGridViewRow row in gridNotBuy.Rows)
            {
                bool ischeck = Convert.ToBoolean(row.Cells[5].Value.ToString());
                //lấy mã sản phẩm tại vị trí hàng thỏa yêu cầu
                string productid = row.Cells[0].Value.ToString();
                foreach(DetailedOrder d in Global.listDetail)
                {
                    if (d.ProductId1 == productid)
                    {
                        Console.WriteLine("is this product");
                        detail = d;
                        break;
                    }
                }
                if (ischeck)
                {
                    Console.WriteLine("check");
                    //insert chi tiết đơn hàng
                    result = OrderDAO.Instance.InsertDetailOrder(newid, detail);
                    if (result > 0)
                    {
                        MessageBox.Show("Thanh toán sản phẩm " + productid + " thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán sản phẩm " + productid + " thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("no check check");
                }
            }
        }
        void LoadComboBoxMethod()
        {
            cbMethod.Items.Add("Thẻ");
            cbMethod.Items.Add("Tiền mặt");
            cbMethod.SelectedIndex = 0;
            txtShipFee.Text = "30";
        }
    }
}

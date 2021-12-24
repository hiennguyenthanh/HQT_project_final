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
    public partial class fDisplayDetailedProduct : Form
    {
        private string SupplierName;
        private Product product;
        private List<DetailedOrder> Details;
        private string CusID;
        public fDisplayDetailedProduct(Product pID, string supplierName, string cusID)
        {
            InitializeComponent();
            this.SupplierName = supplierName;
            this.product = pID;
            this.CusID = cusID;
            LoadInfoChoosenProduct(pID);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadInfoChoosenProduct(Product p)
        {
            try
            {
                txtCSupplierName.Text = SupplierName;
                txtCBranchName.Text = p.BranchID1;
                string query = "select TENLH from LOAIHANG where malh= '" + p.CategoryID1 + "'";

                object temp = DataProvider.Instance.ExecuteScalar(query, null);
                string temp1 = temp.ToString();
                txtCCategory.Text = temp1;
                txtCProductID.Text = p.ProductID1;
                txtCProductName.Text = p.ProductName1;
                txtCSalePrice.Text = p.SalePrice1.ToString();
                txtCDiscount.Text = p.DiscountPrice1.ToString();
                txtInventory.Text = p.NInventory1.ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }

        private void btnCAddtoCart_Click(object sender, EventArgs e)
        {
            string newOrderID;
            int quantity = Convert.ToInt32(numCQuantity.Value.ToString());
            if (quantity == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }
            else
            { 

                //tạo 1 chi tiết đơn hàng tạm thời
                string detailIDProduct = product.ProductID1;
                string detailIDOrder = "<defaul>";
                int detailQuantityProduct = quantity;
                float detailPrice = product.SalePrice1 - product.DiscountPrice1;
                float detailTotal = quantity * detailPrice;
                string name = product.ProductName1;
                DetailedOrder newDetail = new DetailedOrder(detailIDOrder, detailIDProduct, name, detailQuantityProduct, detailPrice, detailTotal);

                ////thêm vào list tạm thời

                Global.listDetail.Add(newDetail);
                
                List<string> l = new List<string>();
                foreach (DetailedOrder item in Global.listDetail)
                {
                    l.Add(item.ProductId1);
                }
                foreach (string s in l)
                {
                    Console.WriteLine(s + " ");
                    Console.WriteLine(l.Count);
                }
                //DetailedOrder d;
                //thêm đơn hàng mới
            }
            //thêm chi tiết đơn hàng
            
        }

        private void btnCanceDetailInfo_Click(object sender, EventArgs e)
        {
            
        }
    }
}

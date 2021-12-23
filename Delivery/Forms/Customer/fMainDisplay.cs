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
    public partial class fMainDisplay : Form
    {
        public int btnHeight = 130;
        public int btnWidth = 130;
        private string SupplierName;
        private string CusID;
        private Form activeForm;
        public fMainDisplay(string cusID)
        {
            InitializeComponent();
            LoadComboBoxSupplier();
            this.CusID = cusID;
           // LoadProductListBySupplierID(this.su)
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //highlight button chosen

            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelCDesktopChild.Controls.Add(childform);
            this.panelCDesktopChild.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }

        private void LoadProductListBySupplierID(string supplierID)
        {
            flowLayoutPanelProduct.Controls.Clear();
            List<Product> list = new List<Product>();
            list = ProductDAO.Instance.GetListProductBySupplierID(supplierID);
            foreach (Product p in list)
            {
                Button btnProduct = new Button() { Width = btnWidth, Height = btnHeight };
                btnProduct.Text = p.ProductName1 + Environment.NewLine + (p.SalePrice1 - p.DiscountPrice1);
                btnProduct.Click += btnProduct_click;

                btnProduct.Tag = p;
                flowLayoutPanelProduct.Controls.Add(btnProduct);
            }

        }
        private void LoadComboBoxSupplier()
        {
            List<Supplier> list = new List<Supplier>();
            list = SupplierDAO.Instance.GetSupplierList();
            cbSupplier.DataSource = list;
            cbSupplier.DisplayMember = "SupplierName1";

           
        }

        private void btnProduct_click(object sender, EventArgs e)
        {
            // string productID = ((sender as Button).Tag as Product).ProductID1;
            //this.Close();
            //this.Hide();
            Product p = (sender as Button).Tag as Product;
            panelCDesktopChild.Controls.Clear();
            panelCDesktopChild.Refresh();
            OpenChildForm(new fDisplayDetailedProduct(p, SupplierName, CusID), null);
        }

          
        private void flowLayoutPanelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
                string supplierid;
                ComboBox cb = (sender as ComboBox);
                if (cb.SelectedItem == null)
                {
                    MessageBox.Show("Chọn tên đối tác đi, nan nỉ !!");
                }
                Supplier selected = cb.SelectedItem as Supplier;
                supplierid = selected.SupplierID1;
                SupplierName = selected.SupplierName1;
                LoadProductListBySupplierID(supplierid);
            
        }

        private void txtCSearchByProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

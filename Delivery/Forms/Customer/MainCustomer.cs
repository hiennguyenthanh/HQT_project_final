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
    public partial class MainCustomer : Form
    {
        public Button currentBtn;
        private Form activeForm;
        private string CusID;
        public MainCustomer(string id)
        {
            InitializeComponent();
            this.CusID = id;
            OpenChildForm(new fDisplayProduct(this.CusID), null);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(135, 162, 182); //xanh nhat
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCCloseChild.Visible = true;


                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelDMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(18, 39, 55);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void Reset()
        {
            DisableButton();
            OpenChildForm(new fDisplayProduct(this.CusID), null);
            currentBtn = null;
            btnCCloseChild.Visible = false;
        }
        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //highlight button chosen
            ActivateButton(btnSender);
            activeForm = childform;
            activeForm.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelCDesktop.Controls.Add(childform);
            this.panelCDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblCTitle.Text = childform.Text;

        }

        private void btnCAcc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customer.fCustomerCart(this.CusID), sender);
        }
    }
}

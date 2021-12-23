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
    public partial class fDisplayProduct : Form
    {
        
        private Form activeForm;
        private string CusID;
       
        public fDisplayProduct(string cusID)
        {
            InitializeComponent();
            this.CusID = cusID;
            OpenChildForm(new fMainDisplay(this.CusID), null);
           
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
            this.panelMainChild.Controls.Add(childform);
            this.panelMainChild.Tag = childform;
            childform.BringToFront();
            childform.Show();
            

        }

        private void panelBackMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fMainDisplay(this.CusID), null);
        }
    }
}

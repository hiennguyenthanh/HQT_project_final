using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.Forms.Staff
{
    public partial class fContract : Form
    {
       
        private Form activeForm;
        private string UserID;
        public fContract(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
            OpenChildForm(new fContractList(this.UserID), null);
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
            this.panelContractChild.Controls.Add(childform);
            this.panelContractChild.Tag = childform;
            childform.BringToFront();
            childform.Show();
            
        }

        private void lblMainBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fContractList(this.UserID), null);
        }
    }
}

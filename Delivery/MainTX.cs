using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery
{
    public partial class MainTX : Form
    {
        public Button currentBtn;
        private Form activeForm;
        private string UserID;
        public MainTX(string userid)
        {
            
            InitializeComponent();
            this.UserID = userid;
            OpenChildForm(new Forms.FormNotDone(this.UserID), null);
            btnDCloseChildForm.Visible = false;
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
                    currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnDCloseChildForm.Visible = true;


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
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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
            this.panelDDesktop.Controls.Add(childform);
            this.panelDDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblDTitle.Text = childform.Text;

        }

        private void btnDAcc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDAccount(this.UserID), sender);
        }

        private void btnDList_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormDDList(), sender);
            OpenChildForm(new Forms.FormOrderList(this.UserID), sender);
        }

        private void btnDDoneList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDDoneList(this.UserID), sender);
        }

        private void btnDExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            OpenChildForm(new Forms.FormNotDone(this.UserID), null);
            currentBtn = null;
            btnDCloseChildForm.Visible = false;
        }


    }
}

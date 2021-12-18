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
    public partial class FormDAccount : Form
    {
        public FormDAccount()
        {
            InitializeComponent();
            LoadInfoDriver("TX1");
        }

        void LoadInfoDriver(string id)
        {
            Driver r = DriverDAO.Instance.GetInfoDriver(id);
            txtDId.Text = r.ID1;
            txtDName.Text = r.Name1;
            txtDCitizenID.Text = r.CMND1;
            txtDPhone.Text = r.Phone1;
            txtDMotor.Text = r.NoMoto1;
            txtDGender.Text = r.Gender1;
            txtDIncome.Text = r.Income1.ToString();
            txtDEmail.Text = r.Email1;
            txtDDob.Text = r.DoB1.ToString();
            txtDBank.Text = r.Bank1;
            txtDNo.Text = r.Addr1[0];
            txtDStreet.Text = r.Addr1[1];
            txtDWard.Text = r.Addr1[2];
            txtDDistrict.Text = r.Addr1[3];
            txtDCity.Text = r.Addr1[4];
            txtDArea.Text = r.Area1;
            txtDLogin.Text = r.Login1;
            txtDPass.Text = r.Pass1;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

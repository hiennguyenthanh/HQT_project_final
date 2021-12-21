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
        private string UserID;
        public FormDAccount(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
            LoadInfoDriver(this.UserID);
        }
        public void UpdateDriverIncome()
        {

        }
        public Driver getInfoFromUI()
        {
            Driver d = new Driver();
            d.ID1 = txtDId.Text.ToString();
            d.Name1 = txtDName.Text.ToString();
            d.CMND1 = txtDCitizenID.Text.ToString();
            d.Phone1 = txtDPhone.Text.ToString();
            d.NoMoto1 = txtDMotor.Text.ToString();
            d.Gender1 = txtDGender.Text.ToString();
            d.Income1 = float.Parse(txtDIncome.Text);
            d.Email1 = txtDEmail.Text.ToString();
            string time = DateTime.Now.ToString("h:mm:ss tt");
            //d.DoB1 = DateTime.ParseExact(txtDDob.Text + " " + time, "MM/dd/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InstalledUICulture);
            DateTime temp = DateTime.ParseExact(txtDDob.Text, "MM/dd/yyyy", null);
            
            d.Bank1 = txtDBank.Text.ToString();
            d.DoB1 = temp;
            d.Addr1[0] = txtDNo.Text.ToString();
            d.Addr1[1] = txtDStreet.Text;
            d.Addr1[2] = txtDWard.Text.ToString();
            d.Addr1[3] = txtDDistrict.Text.ToString();
            d.Addr1[4] = txtDCity.Text.ToString();
            d.Area1 = txtDArea.Text.ToString();
            d.Login1 = txtDLogin.Text.ToString();
            d.Pass1 = txtDPass.Text.ToString();
            return d;
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
            txtDDob.Text = r.DoB1.ToString("MM/dd/yyyy");
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
        void Enable()
        {
            txtDName.Enabled = true;
            txtDCitizenID.Enabled = true;
            txtDPhone.Enabled = true;
            txtDArea.Enabled = true;
            txtDBank.Enabled = true;
            txtDCity.Enabled = true;
            txtDDistrict.Enabled = true;
            txtDDob.Enabled = true;
            txtDMotor.Enabled = true;
            txtDStreet.Enabled = true;
            txtDWard.Enabled = true;
            txtDEmail.Enabled = true;
            txtDNo.Enabled = true;
            txtDGender.Enabled = true;
        }
        void Disable()
        {
            txtDName.Enabled = false;
            txtDCitizenID.Enabled = false;
            txtDPhone.Enabled = false;
            txtDArea.Enabled = false;
            txtDBank.Enabled = false;
            txtDCity.Enabled = false;
            txtDDistrict.Enabled = false;
            txtDDob.Enabled = false;
            txtDMotor.Enabled = false;
            txtDStreet.Enabled = false;
            txtDWard.Enabled = false;
            txtDEmail.Enabled = false;
            txtDNo.Enabled = false;
            txtDGender.Enabled = false;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDUpdateInfo_Click(object sender, EventArgs e)
        {
            Enable();
            txtDIncome.Visible = false;
            btnDCancelUpdate.Visible = true;
            btnDSaveUpdate.Visible = true;
            btnDUpdateInfo.Visible = false;
            btnDChangePass.Visible = false;
        }

        private void btnDSaveUpdate_Click(object sender, EventArgs e)
        {
            Driver d = getInfoFromUI();
            
            bool result = DriverDAO.Instance.UpdateInfo(d);
            if (result)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            txtDIncome.Visible = true;
            btnDCancelUpdate.Visible = false;
            btnDSaveUpdate.Visible = false;
            btnDUpdateInfo.Visible = true;
            btnDChangePass.Visible = true;
            Disable();
        }
    }
}

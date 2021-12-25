using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Delivery.Admin
{
    public partial class TaiKhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2DSFN631\HUYNHTHANHMY;Initial Catalog=QLHD;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void ShowComnboBox()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = new SqlCommand("select * from ACCOUNT", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            cbb_taikhoan.DataSource = table;
            cbb_taikhoan.DisplayMember = "TaiKhoan";
            cbb_taikhoan.ValueMember = "MatKhau";

        }
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from ACCOUNT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            ShowComnboBox();
            loadData();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if(ckb_kichhoat.Checked == true && ckb_khoa.Checked == false)
                MessageBox.Show("Tài khoản đã kích hoạt");
            if (ckb_kichhoat.Checked == false && ckb_khoa.Checked == true)
                MessageBox.Show("Tài khoản đã bị khóa");

            //if (ckb_kichhoat.Checked == true)
            //    MessageBox.Show("Tài khoản đã kích hoạt");
            //else
            //    MessageBox.Show("Tài khoản chưa kích hoạt");

            //if (ckb_khoa.Checked == true)
            //    MessageBox.Show("Tài khoản đã bị khóa");
            //else
            //    MessageBox.Show("Tài khoản đã được mở khóa");
        }
    }
}

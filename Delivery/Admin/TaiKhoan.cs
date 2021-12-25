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

        //public void ShowComnboBox()
        //{
        //    connection = new SqlConnection(str);
        //    connection.Open();
        //    command = new SqlCommand("select * from TAIKHOAN", connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    cbb_taikhoan.DataSource = table;
        //    cbb_taikhoan.DisplayMember = "MaND";
        //    cbb_taikhoan.ValueMember = "MaND";
        //}
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from TaiKhoan";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_taikhoan.DataSource = table;
        }
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            //ShowComnboBox();
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            connection.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "select TrangThai from TaiKhoan where MaNV = '" + cbb_taikhoan.Text + "'";
            //command.ExecuteNonQuery();
            //loadData();
            //if (command.CommandText == Convert.ToString(1))
            //{
            //    ckb_kichhoat.Checked = true;
            //}

            //if (command.CommandText == Convert.ToString(0))
            //{ 
            //    ckb_khoa.Checked = true;
            //}

            if (ckb_kichhoat.Checked == true && ckb_khoa.Checked == false)
            {
                connection = new SqlConnection(str);
                connection.Open();
                loadData();
                command = connection.CreateCommand();
                command.CommandText = "update TaiKhoan set TrangThai = 1 where MaND = '" + tb_taikhoan.Text + "'";
                command.ExecuteNonQuery();
                loadData();
                connection.Close();

                MessageBox.Show("Tài khoản đã kích hoạt");
            }
            else if (ckb_kichhoat.Checked == false && ckb_khoa.Checked == true)
                {
                connection = new SqlConnection(str);
                connection.Open();
                loadData();
                command = connection.CreateCommand();
                command.CommandText = "update TaiKhoan set TrangThai = 0 where MaND = '" + tb_taikhoan.Text + "'";
                command.ExecuteNonQuery();
                loadData();
                connection.Close();

                MessageBox.Show("Tài khoản đã bị khóa");
                }
                
            else
            {
                MessageBox.Show("Thao tác thực hiện sai");
            }

            //if (ckb_kichhoat.Checked == true)
            //    MessageBox.Show("Tài khoản đã kích hoạt");
            //else
            //    MessageBox.Show("Tài khoản chưa kích hoạt");
            //if (ckb_khoa.Checked == true)
            //    MessageBox.Show("Tài khoản đã bị khóa");
            //else
            //    MessageBox.Show("Tài khoản đã được mở khóa");
        }

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_taikhoan.CurrentRow.Index;
            tb_taikhoan.Text = dgv_taikhoan.Rows[i].Cells[0].Value.ToString();

            //command = connection.CreateCommand();
            //command.CommandText = "select TrangThai from TaiKhoan where MaND = '" + tb_taikhoan.Text + "'";
            //command.ExecuteNonQuery();
            //loadData();

            //if (command.CommandText == Convert.ToString(1))
            //{
            //    ckb_kichhoat.Checked = true;
            //}

            //if (command.CommandText == Convert.ToString(0))
            //{
            //    ckb_khoa.Checked = true;
            //}
        }
    }
}

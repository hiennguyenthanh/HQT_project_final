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
    public partial class NhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2DSFN631\HUYNHTHANHMY;Initial Catalog=QLHD;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_nhanvien.DataSource = table;
        }
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            connection.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.ReadOnly = true;// Ma nhan vien khong the thay doi
            int i;
            i = dgv_nhanvien.CurrentRow.Index;
            tb_manv.Text = dgv_nhanvien.Rows[i].Cells[0].Value.ToString();
            tb_tennv.Text = dgv_nhanvien.Rows[i].Cells[1].Value.ToString();
            tb_ngaysinh.Text = dgv_nhanvien.Rows[i].Cells[2].Value.ToString();
            tb_gioitinh.Text = dgv_nhanvien.Rows[i].Cells[3].Value.ToString();
           // tb_userid.Text = dgv.Rows[i].Cells[4].Value.ToString();
           // tb_userpass.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into TAIKHOAN values('" + tb_manv.Text + "', '" + tb_userid.Text + "', '" + tb_userpass.Text + "', 1)";
            command.ExecuteNonQuery();
            loadData();

            command.CommandText = "insert into NHANVIEN values('" + tb_manv.Text + "', '" + tb_tennv.Text + "', '" + tb_ngaysinh.Text + "', '" + tb_gioitinh.Text + "')";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Đã thêm nhân viên thành công");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NHANVIEN where MaNV = '" + tb_tennv.Text + "'";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Đã xóa nhân viên thành công");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NHANVIEN set MaNV = '" + tb_tennv.Text + "', TenNV = '" + tb_tennv + "', NgaySinh = '" + tb_ngaysinh.Text + "', GioiTinh = '" + tb_gioitinh.Text + "' where MaNV = '" + tb_tennv.Text + "'";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Đã sửa thông tin nhân viên thành công");
        }
    }
}

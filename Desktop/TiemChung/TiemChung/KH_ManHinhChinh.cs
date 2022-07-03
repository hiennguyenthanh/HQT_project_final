using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace Hien
{

    public partial class KH_ManHinhChinh : Form
    {
        public KH_ManHinhChinh(String MaKH)
        {
            InitializeComponent();
            LoadThongTinCaNhan(MaKH);
            LoadDSHoaDon(MaKH);
        }
        void LoadDSHoaDon(String MaKH)
        {
            string connectionString = "Data Source=HIENNGUYENTHANH;Initial Catalog=TiemChung;Integrated Security=True";
        	SqlConnection connection = new SqlConnection(connectionString);
        	string query = "Select * from HoaDon where MaKhachHang = " + MaKH;
        	
        	connection.Open();
        	
        	SqlCommand command = new SqlCommand(query, connection);
    		DataTable data = new DataTable();
        	SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(data);
			
			connection.Close();
			
			dtgtHoaDon.DataSource = data;	
        }
        void LoadChiTietHoaDon(string MaHD, string MaKH)
        {
        	
        }
        void LoadThongTinCaNhan(string MaKH){
        	txtMaKH.Text = MaKH;
//        	txtHoTen = 
        }
        private void labelThongTinCaNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void KH_ManHinhChinh_Load(object sender, EventArgs e)
        {

        }
        
        void Button3Click(object sender, EventArgs e)
        {
        	
        }
    }
}

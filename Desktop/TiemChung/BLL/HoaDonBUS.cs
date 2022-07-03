/*
 * Created by SharpDevelop.
 * User: VQ
 * Date: 6/11/2022
 * Time: 2:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
	/// <summary>
	/// Description of HoaDonBLL.
	/// </summary>
	public class HoaDonBLL
	{
		public List<HoaDon> LoadHoaDonBLL(KhachHang KH)
		{
			List<HoaDon> listHoaDon = new List<HoaDon>();
	        HoaDon ds =  new HoaDon("HD1", "1", "PDK", "1/1/2022", "0", "Chua thanh toan");
	        listHoaDon.Add(ds);
      		
            string connectionString = "Data Source=HIENNGUYENTHANH;Initial Catalog=QuanLyTiemChung;Integrated Security=True";
        	SqlConnection connection = new SqlConnection(connectionString);
        	string query = "Select * from HoaDon where MaKH = " + KH._MaKH;
        	
        	connection.Open();
        	
        	SqlCommand command = new SqlCommand(query, connection);
    		DataTable data = new DataTable();
        	SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(data);
			
			connection.Close();
			
			return listHoaDon;
		}
	}
}

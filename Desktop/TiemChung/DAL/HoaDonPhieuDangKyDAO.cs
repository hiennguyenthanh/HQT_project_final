/*
 * Created by SharpDevelop.
 * User: VQ
 * Date: 6/11/2022
 * Time: 2:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DTO;
namespace DAO
{

	public class HoaDonDAO
	{
		public static List<HoaDon>DisplayList(KhachHang kh)
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "select * from HoaDon where MaKH='"+kh._MaKH+"'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new HoaDon(row));
            }
            return list;
        }
	}
}

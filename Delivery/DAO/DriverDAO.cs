using Delivery.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAO
{
    public class DriverDAO
    {
        private static DriverDAO instance;

        public static DriverDAO Instance { get { if (instance == null) DriverDAO.instance = new DriverDAO(); return DriverDAO.instance; } private set => instance = value; }
        private DriverDAO()
        {
        }
        
        public Driver GetInfoDriver(string id)
        {
            Driver r = null;
            string query = "USP_GetInfoDriver @matx";
            DataTable data = new DataTable();
            DataTableReader reader = null;
            try
            {
                data = DataProvider.Instance.ExecuteQuery1(query, new object[] { id });
                

            }
            catch(SqlException e)
            {
                Console.WriteLine("SQL ERROR: " + e.Message);
            }
            foreach (DataRow item in data.Rows)
            {
                //lấy trạng thái tài khoản từ bảng 
                string temp = item[3].ToString();
                int num = Convert.ToInt32(temp);
                r = new Driver(item);
                r.StatusAcc1 = num;
            }
            return r;
        }
        public bool UpdateInfo(Driver d)
        {
            int result;
            string query = "USP_UpdateInfoDriver @matx , @tentx , @cmnd , @gioitinh , @ngaysinh , @sdt , @biensoxe , @khuvuc , @email , @tk , @sonha , @duong , @phuong , @quan , @tp";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {d.ID1,d.Name1,d.CMND1,d.Gender1,
                                                                           d.DoB1,d.Phone1,d.NoMoto1,d.Area1,d.Email1,d.Bank1,
                                                        Convert.ToInt32(d.Addr1[0]),d.Addr1[1],d.Addr1[2],d.Addr1[3],d.Addr1[4] });
            return result>0;
        }
        public bool UpdateChoosenOrder(string OrderID, string DriverID)
        {
            string query = "USP_UpdateIDDriverIntoOrder @madh , @matx";
            // thêm mã tài xế vào đơn hàng đã chọn
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { OrderID, DriverID });
            return result > 0;
        }
        public bool UpdateOrderStatus (string OrderID, string DriverID, string choosenStatus)
        {
            string query = "USP_UpdateDriverOrderStatus @madh , @matx , @status";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { OrderID, DriverID, choosenStatus });
            return result > 0;
        }
    }
}

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
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance { get { if (instance == null) OrderDAO.instance = new OrderDAO(); return OrderDAO.instance; } private set => instance = value; }
        private OrderDAO()
        {
        }
        
        //lấy danh sách những đơn hàng mà tài xế đã chọn theo mã tài xế 
        //trạng thái đơn hàng: Tài xế đã nhận hàng
        public List<Order> GetListNotDoneOrderById(string id)
        {
            List<Order> list = new List<Order>();
           
            string query = "USP_ShowNotDoneOrderByArea @matx";
            DataTable table = new DataTable();
         
            try
            { 
                table = DataProvider.Instance.ExecuteQuery1(query,new object[] {id});
            }
            catch
            {
                Console.WriteLine("sai");
                
            }
           
            foreach (DataRow item in table.Rows)
            {
                Order order = new Order(item);
                list.Add(order);
            }
            return list;
        }

        public string formatStr(string status)
        {
            string r;
            r = "N" + status;
            return r;
        }
        public List<Order> GetListDoneOrderById(string id)
        {
            List<Order> list = new List<Order>();
            string query = "USP_ShowDoneOrderByArea @matx , @status";
            DataTable table = new DataTable();
            string status = "Đã giao";
           
            try
            {
                table = DataProvider.Instance.ExecuteQuery1(query, new object[] { id, status});
                
            }
            catch
            {
                Console.WriteLine("sai");

            }

            foreach (DataRow item in table.Rows)
            {
                Order order = new Order(item);
                list.Add(order);
            }
            return list;
        }
        public List<Order> GetListOrderByAreaOfDriver(string id)
        {
            List<Order> list = new List<Order>();
            string query = "USP_GetAllOrderByAreaOfDriver @matx";
            DataTable table = new DataTable();

            try
            {
                table = DataProvider.Instance.ExecuteQuery1(query, new object[] { id });
            }
            catch
            {
                Console.WriteLine("sai");

            }

            foreach (DataRow item in table.Rows)
            {
                Order order = new Order(item);
                list.Add(order);
            }
            return list;
        }
        public Order GetOrder(string id)
        {
            Order order = new Order();
            string query = " USP_GetInfoOrder @madh";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery1(query, new object[] { id });
            }
            catch (SqlException e)
            {
                Console.WriteLine("SQL ERROR: " + e.Message);
            }

            foreach (DataRow item in table.Rows)
            {
                order = new Order(item);
            }
        
            return order;

        }
        //insert đơn hàng mới đồng thời trả về mã đơn hàng vừa tạo
        public string InsertOrder(string cusid, string status, string method, float fee, DateTime date)
        {
            string query = "USP_InsertOrder @makh , @tinhtrang , @hinhthuc , @phivc , @thoigian";
            string newid = "";
            DataTable r = DataProvider.Instance.ExecuteQuery1(query, new object[] { cusid, status,method,fee,date });
            if (r.Rows.Count == 1)
            {
                foreach (DataRow item in r.Rows)
                {
                    newid = item["MADH"].ToString();
                }
            }

            return newid;
        }
        public int InsertDetailOrder(string orderID, DetailedOrder d)
        {
            string query = "USP_InsertDetailOrder @madh , @masp , @sl , @gia , @thanhtien";
            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderID, d.ProductId1, d.Quality1, d.Price1, d.TotalPrice1 });
            return r;
        }
    }
}

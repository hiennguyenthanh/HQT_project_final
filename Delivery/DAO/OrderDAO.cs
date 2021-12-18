using Delivery.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Order> GetListDoneOrderById(string id)
        {
            List<Order> list = new List<Order>();
            string query = "USP_ShowDoneOrderByArea @matx";
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
    }
}

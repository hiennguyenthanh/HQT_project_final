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
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance { get { if (instance == null) ProductDAO.instance = new ProductDAO(); return ProductDAO.instance; } private set => instance = value; }
        private ProductDAO()
        {
        }

        public List<Product> GetListProductBySupplierID(string supplierID){
            List<Product> list = new List<Product>();

            string query = "select* from SANPHAM where MADT= '" + supplierID + "'";
            DataTable table = new DataTable();

            try
            {
                table = DataProvider.Instance.ExecuteQuery1(query, null);
            }
            catch (SqlException e)
            {

                Console.WriteLine("SQL EXCEPTION: " + e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("EXCEPTION: " + e.Message);
            }

            foreach (DataRow item in table.Rows)
            {
                Product p = new Product(item);
                list.Add(p);
            }
            return list;
        }
        public List<string> GetSupplierList()
        {
            List<string> list = new List<string>();
            string query = "select TenDT from DOITAC ";
            DataTable table = new DataTable();

            try
            {
                table = DataProvider.Instance.ExecuteQuery1(query, null);
            }
            catch (SqlException e)
            {

                Console.WriteLine("SQL EXCEPTION: " + e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("EXCEPTION: " + e.Message);
            }

            foreach (DataRow item in table.Rows)
            {
                string s = item["TenDT"].ToString();
                list.Add(s);
            }
            return list;
        }
        
    }
}

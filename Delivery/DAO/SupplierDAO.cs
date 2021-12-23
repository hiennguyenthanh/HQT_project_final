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
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public static SupplierDAO Instance { get { if (instance == null) SupplierDAO.instance = new SupplierDAO(); return SupplierDAO.instance; } private set => instance = value; }
        private SupplierDAO()
        {
        }

        public List<Supplier> GetSupplierList()
        {
            List<Supplier> list = new List<Supplier>();
            string query = "select*from DOITAC";
            
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
                Supplier s = new Supplier(item);
                list.Add(s);
            }
            return list;
        }
    }
}

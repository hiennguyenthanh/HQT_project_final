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
                r = new Driver(item);
            }
            return r;
        }
    }
}

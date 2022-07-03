using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTiemChung
{
    class DataProvider
    {
        private static string path = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyTiemChung;Integrated Security=True";

        public static DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand mysqlCommand = new SqlCommand(query, connection);
                SqlDataAdapter adpt = new SqlDataAdapter(mysqlCommand);
                adpt.Fill(data);
                connection.Close();
            }
            return data;
        }

        public static int ExecuteNonQuery(string query)
        {
            int successfulRows = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand mysqlCommand = new SqlCommand(query, connection);
                successfulRows = mysqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            return successfulRows;
        }

        public static object ExecuteScalar(string query)
        {
            object count = 0;
            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand mysqlCommand = new SqlCommand(query, connection);
                count = mysqlCommand.ExecuteScalar();
                connection.Close();
            }
            return count;
        }
    }
}

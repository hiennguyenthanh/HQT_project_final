using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } private set => Instance = value; }

        private DataProvider() { }

        private string connectStr = "Data Source=.\\sqlexpress;Initial Catalog=QLHD;Integrated Security=True";

        public DataTable ExecuteQuery1(string query, object[] parameter=null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split();
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            //command.Parameters.Add(item, SqlDbType.NVarChar | SqlDbType.Money | SqlDbType.Int).Value = parameter[i];
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                        
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                DataTable data = new DataTable();
                SqlConnection connection = new SqlConnection(connectStr);

                
                SqlCommand command = new SqlCommand(query, connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@matx", SqlDbType.NVarChar).Value = "TX3";
                /*if (param != null)
                {
                    string[] listparam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparam)
                    {
                        if (item.Contains('@'))
                        {
    
                            //command.Parameters.AddWithValue(item, param[i].ToString());
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }*/
                connection.Open();
                data.Load(command.ExecuteReader());
                
                //SqlDataAdapter adapter = new SqlDataAdapter(command);

                //adapter.Fill(data);
                connection.Close();


                Console.WriteLine("yeah");
                return data;
            }
            catch(SqlException e)
            {
                Console.WriteLine("wrong" + e.ToString());
                return new DataTable();
            }
            
        }

        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (param != null)
                {
                    string[] listparam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (param != null)
                {
                    string[] listparam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listparam)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

        public DataTable execute(string query)
        {
            DataTable db = new DataTable();
            using (SqlConnection c=new SqlConnection(connectStr))
            {
                try
                {
                    using (SqlDataAdapter a=new SqlDataAdapter())
                    {
                        a.SelectCommand = new SqlCommand(query, c);
                        a.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet ds = new DataSet();
                        a.Fill(ds, "result");
                       
                        db = ds.Tables["result"];
                    }
                    return db;
                }
                catch (SqlException e)
                {
                    Console.WriteLine("sql exception: " + e.Message);
                    return new DataTable();
                } 
                catch (Exception ex)
                {
                    Console.WriteLine("ex: " + ex.Message);
                    return new DataTable();
                }
            }
        }

    }
}

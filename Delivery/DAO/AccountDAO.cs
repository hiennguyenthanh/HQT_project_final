using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { get { if (instance == null) AccountDAO.instance = new AccountDAO(); return AccountDAO.instance; } private set => instance = value; }
        private AccountDAO()
        {
        }

        //trả về ID và trạng thái của tài khoản
        public string[] Login(string username, string password)
        {
            string ID="";
            string status="";
            string query = "USP_CheckAccountExist @loginname , @pass";
            string query1 = "USP_GetUserID @loginname , @pass";
            DataTable table = DataProvider.Instance.ExecuteQuery1(query, new object[] { username, password });
            if (table.Rows.Count > 0)
            {
                //nếu có tồn tại tài khoản trong database
                //lấy ra id
                DataTable data = DataProvider.Instance.ExecuteQuery1(query1, new object[] { username, password });
                DataRow row = data.Rows[0];
                ID = row["MAND"].ToString();
                status = row["TrangThai"].ToString();
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản");
            }
            string[] r = { ID, status };
            return r;
        }
        public bool InsertAccount(string user, string pass, string role)
        {
            int result;
            string query = "USP_InsertAccount @loginname , @pass , @roleUser";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, pass, role });
            return result > 0;
        }
    }
}

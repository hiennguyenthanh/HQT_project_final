using Delivery.DAO;
using Delivery.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Delivery.Forms
{
    public partial class FormNotDone : Form
    {
        
        private string selectedOrderID;
        private string selectedOrderStatus;
        private string UserID;
        public FormNotDone(string userid)
        {
            InitializeComponent();
            this.UserID = userid;
            LoadNotDoneListByID(this.UserID);
            LoadInfoCombobox();
        }

        void LoadNotDoneListByID(string id)
        {
            //gridNotDone.DataSource = OrderDAO.Instance.GetListOrderById(id);
            List<Order> list = new List<Order>();
            list = OrderDAO.Instance.GetListNotDoneOrderById(id);
            int length = list.Count();
            int i = 0;
            while (i < length)
            {
                string mahd = (string)list[i].ID1;
                string tinhtrang = (string)list[i].Status1;
                string diachi = (string)list[i].OAddr1;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(gridNotDone);
                newrow.Cells[0].Value = mahd.ToUpper();
                newrow.Cells[1].Value = tinhtrang;
                newrow.Cells[2].Value = diachi;
                gridNotDone.Rows.Add(newrow);
                i++;
            }

            //hiện khu vực hoạt động
            string area = "";
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExecuteQuery1("select * from TAIXE where MaTX = '" + id + "'");
            foreach (DataRow row in table.Rows)
            {
                Driver d = new Driver(row);
                area = d.Area1;
            }
            btnArea.Text = area;
            
        }

        private void gridNotDone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void FormNotDone_Load(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void gridNotDone_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = gridNotDone.Rows[index];
            selectedOrderID = row.Cells[0].Value.ToString();
            string status = row.Cells[1].Value.ToString();
            cbOrderStatus.Text= status;
            btnDUpdateOrdeStatus.Visible = true;

        }
        public void LoadInfoCombobox()
        {
            cbOrderStatus.Items.Add("Tài xế đã nhận hàng");
            cbOrderStatus.Items.Add("Đang giao");
            cbOrderStatus.Items.Add("Đã giao");

        }

        //lưu thay đổi trạng thái đơn hàng 
        private void btnDUpdateOrdeStatus_Click(object sender, EventArgs e)
        {
            selectedOrderStatus = cbOrderStatus.SelectedItem.ToString();
            bool result = DriverDAO.Instance.UpdateOrderStatus(selectedOrderID, this.UserID, selectedOrderStatus);
            if (result)
            {
                MessageBox.Show("Cập nhật trạng thái đơn hàng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái đơn hàng thất bại");
            }
            //xóa dữ liệu cũ và  load lại dữ liệu mới
            gridNotDone.Rows.Clear();
                
            this.LoadNotDoneListByID(this.UserID);
            btnDUpdateOrdeStatus.Visible = false;

            //cập nhật lại thu nhập nếu đơn hàng vừa sửa có trạng thái là đã giao
            //thêm đơn hàng đó vào bảng thu nhập
            if (selectedOrderStatus=="Đã giao")
            {
                string query1 = "EXEC dbo.USP_InsertOrderIntoIncomeDriver @madh";
                DataProvider.Instance.ExecuteNonQuery(query1, new object[] { selectedOrderID });
                //cập nhật thu nhập
                string query2 = "EXEC dbo.USP_UpdateDriverIncome @matx";
                DataProvider.Instance.ExecuteNonQuery(query2, new object[] { this.UserID });
            }
        }
    }
}

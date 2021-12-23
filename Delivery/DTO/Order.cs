using Delivery.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class Order
    {
        private string ID;
        private string CusID;
        private string DriverID;
        private string Status;
        private string Method;
        private string OAddr;
        private float ShipFee;
        private float Total;
        private DateTime TimeOrder;

        public Order(string iD, string cusID, string driverID, string status, string method, string oAddr, float shipFee, float total, DateTime timeOrder)
        {
            ID = iD;
            CusID = cusID;
            DriverID = driverID;
            Status = status;
            Method = method;
            OAddr = oAddr;
            ShipFee = shipFee;
            Total = total;
            TimeOrder = timeOrder;
        }
        public Order()
        {
            ID = null;
            CusID = null;
            DriverID = null;
            Status = null;
            Method = null;
            OAddr = null;
            ShipFee = 0;
            Total = 0;
            TimeOrder = DateTime.Now;
        }
        public Order(DataRow row)
        {
            this.ID = (string)row["MaDH"];
            this.Status = (string)row["TinhTrangDH"];
            this.OAddr= (string)row["DiaChiGiao"];
            this.CusID = (string)row["MaKH"];
            if (row["MATX"] == DBNull.Value)
            {
                this.DriverID = "";
            }
            else
            {
                this.DriverID = (string)row["MaTX"];
            }
            
            this.Method = (string)row["HinhThucThanhToan"];
            var money = Convert.ToDecimal(row["PhiVC"]);
            this.ShipFee = (float)money;
            var money1= Convert.ToDecimal(row["TongTien"]);
            this.Total = (float)money1;
            this.TimeOrder = (DateTime)row["ThoiGianDatHang"];
        }

       
        public string ID1 { get => ID; set => ID = value; }
        public string CusID1 { get => CusID; set => CusID = value; }
        public string DriverID1 { get => DriverID; set => DriverID = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Method1 { get => Method; set => Method = value; }
        public string OAddr1 { get => OAddr; set => OAddr = value; }
        public float ShipFee1 { get => ShipFee; set => ShipFee = value; }
        public float Total1 { get => Total; set => Total = value; }
        public DateTime TimeOrder1 { get => TimeOrder; set => TimeOrder = value; }
    }
}

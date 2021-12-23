using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class Supplier
    {
        private string SupplierID;
        private string SupplierName;
        private string Represent;
        private int NBranch;
        private int NOrder;
        private string SCategory;
        private string SPhone;
        private string SMail;
        private string CodeTax;
        private string[] Addr;

        public Supplier(string supplierID, string supplierName, string represent, int nBranch, int nOrder, string sCategory, string sPhone, string sMail, string codeTax, string[] addr)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            Represent = represent;
            NBranch = nBranch;
            NOrder = nOrder;
            SCategory = sCategory;
            SPhone = sPhone;
            SMail = sMail;
            CodeTax = codeTax;
            Addr = addr;
        }
        public Supplier(DataRow row)
        {
            if (row["MADT"] == DBNull.Value)
            {
                this.SupplierID = "";
            }
            else
            {
                this.SupplierID = (string)row["MADT"];
            }
            if (row["TENDT"] == DBNull.Value)
            {
                this.SupplierName = "fdhfh";
            }
            else
            {
                this.SupplierName = row["TENDT"].ToString();
            }
            if (row["NGUOIDAIDIEN"] == DBNull.Value)
            {
                this.Represent = "";
            }
            else
            {
                this.Represent = (string)row["NGUOIDAIDIEN"];
            }
            if (row["SOCHINHANH"] == DBNull.Value)
            {
                this.NBranch = 0;
            }
            else
            {
                this.NBranch = (int)row["SOCHINHANH"];
            }
            if (row["SOLUONGDH"] == DBNull.Value)
            {
                this.NOrder = 0;
            }
            else
            {
                this.NOrder = (int)row["SOLUONGDH"]; 
            }
            if (row["LOAIHANG"] == DBNull.Value)
            {
                this.SCategory = "";
            }
            else
            {
                this.SCategory = (string)row["LOAIHANG"];
            }
            if (row["SDT_DT"] == DBNull.Value)
            {
                this.SPhone = "";
            }
            else
            {
                this.SPhone = (string)row["SDT_DT"];
            }
            if (row["EMAIL_DT"] == DBNull.Value)
            {
                this.SMail = "";
            }
            else
            {
                this.SMail = (string)row["EMAIL_DT"];
            }
            if (row["MASOTHUE"] == DBNull.Value)
            {
                this.CodeTax = "";
            }
            else
            {
                this.CodeTax = (string)row["MASOTHUE"];
            }
            this.Addr = Supplier.CovertToAddress(row);
        }
        public static string[] CovertToAddress(DataRow row)
        {
            int No;
            string street, ward, district, city;
            
            if (row["SONHA"] == DBNull.Value)
            {
                No = 0;
            }
            else
            {
                No = (int)row["SONHA"];
            }
            if (row["Duong"] == DBNull.Value)
            {
                street = "";
            }
            else
            {
                street = (string)row["Duong"];
            }
            if (row["Phuong"] == DBNull.Value)
            {
                ward = "";
            }
            else
            {
                ward = (string)row["Phuong"];
            }
            if(row["Quan"] == DBNull.Value)
            {
                district = "";
            }
            else
            {
                district = (string)row["Quan"];
            }
            if (row["ThanhPho"] == DBNull.Value)
            {
                city = "";
            }
            else
            {
                city = (string)row["ThanhPho"];
            }
            string[] r = { No.ToString(), street.ToString(), ward.ToString(), district.ToString(), city.ToString() };
            return r;
        }

        public string SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public string SupplierName1 { get => SupplierName; set => SupplierName = value; }
        public string Represent1 { get => Represent; set => Represent = value; }
        public int NBranch1 { get => NBranch; set => NBranch = value; }
        public int NOrder1 { get => NOrder; set => NOrder = value; }
        public string SCategory1 { get => SCategory; set => SCategory = value; }
        public string SPhone1 { get => SPhone; set => SPhone = value; }
        public string SMail1 { get => SMail; set => SMail = value; }
        public string CodeTax1 { get => CodeTax; set => CodeTax = value; }
        public string[] Addr1 { get => Addr; set => Addr = value; }
    }
}

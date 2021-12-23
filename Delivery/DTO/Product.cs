using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class Product
    {
        private string ProductID;
        private string CategoryID;
        private string SupplierID;
        private string ProductName;
        private string BranchID;
        private float SalePrice;
        private float DiscountPrice;
        private int NInventory;

        public string ProductID1 { get => ProductID; set => ProductID = value; }
        public string CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public string BranchID1 { get => BranchID; set => BranchID = value; }
        public float SalePrice1 { get => SalePrice; set => SalePrice = value; }
        public float DiscountPrice1 { get => DiscountPrice; set => DiscountPrice = value; }
        public int NInventory1 { get => NInventory; set => NInventory = value; }

        //hinh ảnh tính sau, byte[]

        public Product(string productID, string categoryID, string supplierID, string productName, string branchID, float salePrice, float discountPrice, int nInventory)
        {
            ProductID = productID;
            CategoryID = categoryID;
            SupplierID = supplierID;
            ProductName = productName;
            BranchID = branchID;
            SalePrice = salePrice;
            DiscountPrice = discountPrice;
            NInventory = nInventory;
        }
        public Product(DataRow row)
        {
            if (row["MASP"] == DBNull.Value)
            {
                this.ProductID = "";
            }
            else
            {
                this.ProductID = (string)row["MASP"];
            }
            if (row["MADT"] == DBNull.Value)
            {
                this.SupplierID = "";
            }
            else
            {
                this.SupplierID = (string)row["MADT"];
            }
            if (row["TENSP"] == DBNull.Value)
            {
                this.ProductName = "";
            }
            else
            {
                this.ProductName = (string)row["TENSP"];
            }
            if (row["MACN"] == DBNull.Value)
            {
                this.BranchID = "";
            }
            else
            {
                this.BranchID = (string)row["MACN"];
            }
            if (row["GIABAN"] == DBNull.Value)
            {
                this.SalePrice = 0;
            }
            else
            {
                var money = Convert.ToDecimal(row["GIABAN"]);
                this.SalePrice = (float)money;
            }
            if (row["GIAGIAM"] == DBNull.Value)
            {
                this.DiscountPrice = 0;
            }
            else
            {
                var money1 = Convert.ToDecimal(row["GIAGIAM"]);
                this.DiscountPrice = (float)money1;
            }
            if (row["MALOAIHANG"] == DBNull.Value)
            {
                this.CategoryID = "";
            }
            else
            {
                this.CategoryID = (string)row["MALOAIHANG"];
            }
            if (row["SOLUONGTON"] == DBNull.Value)
            {
                this.NInventory = 0;
            }
            else
            {
                this.NInventory = (int)row["SOLUONGTON"];
            }

        }
    }
}


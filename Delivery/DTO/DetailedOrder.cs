using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class DetailedOrder
    {
        private string  OrderID;
        private string ProductId;
        private int Quality;
        private float Price;
        private float TotalPrice;
        private string ProductName;

        public DetailedOrder(string orderiD, string productId, string productName, int quality, float price, float totalPrice)
        {
            OrderID = orderiD;
            ProductId1 = productId;
            Quality1 = quality;
            Price1 = price;
            TotalPrice1 = totalPrice;
            ProductName = productName;
        }

        public DetailedOrder()
        {

        }
        public string OrderID1 { get => OrderID; set => OrderID = value; }
        public string ProductId1 { get => ProductId; set => ProductId = value; }
        public int Quality1 { get => Quality; set => Quality = value; }
        public float Price1 { get => Price; set => Price = value; }
        public float TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
    }
}

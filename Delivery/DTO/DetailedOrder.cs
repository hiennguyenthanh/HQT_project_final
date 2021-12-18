using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DTO
{
    public class DetailedOrder
    {
        private string ID;
        private string ProductId;
        private int Quality;
        private float Price;
        private float TotalPrice;

        public DetailedOrder(string iD, string productId, int quality, float price, float totalPrice)
        {
            ID1 = iD;
            ProductId1 = productId;
            Quality1 = quality;
            Price1 = price;
            TotalPrice1 = totalPrice;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string ProductId1 { get => ProductId; set => ProductId = value; }
        public int Quality1 { get => Quality; set => Quality = value; }
        public float Price1 { get => Price; set => Price = value; }
        public float TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }
    }
}

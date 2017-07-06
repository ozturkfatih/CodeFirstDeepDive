using System;
using CodeFirstDeepDive.Enums;

namespace CodeFirstDeepDive.Entity
{
    public class BookPrice
    {
        public int Id { get; set; }
        public decimal Purchase { get; set; }
        public int Rate { get; set; }
        public decimal SalePrice { get; set; }
        public DateTimeOffset SellBy { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public SalesSituation SalesSituation { get; set; }

    }
}
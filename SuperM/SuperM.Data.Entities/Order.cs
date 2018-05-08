namespace SuperM.Data.Entities
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public DateTime OrderTime { get; set; }

        public decimal GrossTotal { get; set; }

        public decimal NationTax { get; set; }

        public decimal ProvinceTax { get; set; }

        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}

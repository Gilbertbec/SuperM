namespace SuperM.Data.Entities
{
    using System.Collections.Generic;

    public class OrderAndOrderDetailForCheckOut
    {
        public Order Order { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
    }
}

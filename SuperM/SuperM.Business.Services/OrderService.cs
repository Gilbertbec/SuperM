namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderService
    {
        private SuperMContext Context;

        public OrderService()
        {
            Context = new SuperMContext();
        }

        public List<Order> GetOrderList()
        {
            var orders = Context.Orders.ToList();
            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            Order order = Context.Orders.FirstOrDefault(x => x.OrderId == orderId);
            return order;
        }

        public void Add(Order order)
        {
            Context.Orders.Add(order);
            Context.SaveChanges();
        }

        public void DeleteOrderById(int orderId)
        {
            Order order = GetOrderById(orderId);
            Context.Orders.Remove(order);
            Context.SaveChanges();
        }

        public void UpdateOrderByOrder(Order order)
        {
            var Order = GetOrderById(order.OrderId);
            if (Order != null)
            {
                Order.OrderId = order.OrderId;
                Order.UserId = order.UserId;
                Order.OrderTime = order.OrderTime;
                Order.GrossTotal = order.GrossTotal;
                Order.NationTax = order.NationTax;
                Order.ProvinceTax = order.ProvinceTax;
                Order.Total = order.Total;
                Order.OrderDetails = order.OrderDetails;
            }
            Context.SaveChanges();
        }
    }
}

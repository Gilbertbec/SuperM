namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrdersService
    {
        private SuperMContext Context;

        public OrdersService()
        {
            Context = new SuperMContext();
        }

        public List<Order> GetOrdersList()
        {
            var orderss = Context.Orders.ToList();
            return orderss;
        }

        public Order GetOrdersById(int ordersId)
        {
            Order orders = Context.Orders.FirstOrDefault(x => x.OrderId == ordersId);
            return orders;
        }

        public int Add(Order order)
        {
            Context.Orders.Add(order);
            Context.SaveChanges();
            return order.OrderId;
        }

        public void DeleteOrdersById(int ordersId)
        {
            Order orders = GetOrdersById(ordersId);
            Context.Orders.Remove(orders);
            Context.SaveChanges();
        }

        public void UpdateOrdersByOrder(Order order)
        {
            var Orders = GetOrdersById(order.OrderId);
            if (Orders != null)
            {
            }
            Context.SaveChanges();
        }
    }
}

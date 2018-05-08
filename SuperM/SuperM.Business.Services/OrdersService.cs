namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrdersService
    {
        private SuperMContext _context;

        public OrdersService()
        {
            _context = new SuperMContext();
        }

        public List<Order> GetOrdersList()
        {
            var orderss = _context.Orders.ToList();
            return orderss;
        }

        public Order GetOrdersById(int ordersId)
        {
            Order orders = _context.Orders.FirstOrDefault(x => x.OrderId == ordersId);
            return orders;
        }

        public int Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order.OrderId;
        }

        public void DeleteOrdersById(int ordersId)
        {
            Order orders = GetOrdersById(ordersId);
            _context.Orders.Remove(orders);
            _context.SaveChanges();
        }

        public void UpdateOrdersByOrder(Order order)
        {
            var Orders = GetOrdersById(order.OrderId);
            if (Orders != null)
            {
            }
            _context.SaveChanges();
        }
    }
}

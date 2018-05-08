namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderHistoriesService
    {
        private SuperMContext _context;

        public OrderHistoriesService()
        {
            _context = new SuperMContext();
        }

        public List<OrderHistory> GetOrderHistoriesList()
        {
            var orderHistoriess = _context.OrderHistories.ToList();
            return orderHistoriess;
        }

        public OrderHistory GetOrderHistoriesById(int orderHistoriesId)
        {
            OrderHistory orderHistories = _context.OrderHistories.FirstOrDefault(x => x.OrderHistoryId == orderHistoriesId);
            return orderHistories;
        }

        public void Add(OrderHistory orderHistory)
        {
            _context.OrderHistories.Add(orderHistory);
            _context.SaveChanges();
        }

        public void DeleteOrderHistoriesById(int orderHistoriesId)
        {
            OrderHistory orderHistories = GetOrderHistoriesById(orderHistoriesId);
            _context.OrderHistories.Remove(orderHistories);
            _context.SaveChanges();
        }

        public void UpdateOrderHistoriesByOrderHistories(OrderHistory orderHistory)
        {
            var OrderHistories = GetOrderHistoriesById(orderHistory.OrderHistoryId);
            if (OrderHistories != null)
            {
            }
            _context.SaveChanges();
        }
    }
}

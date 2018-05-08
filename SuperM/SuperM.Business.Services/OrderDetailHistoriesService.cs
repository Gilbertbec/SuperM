namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderDetailHistoriesService
    {
        private SuperMContext _context;

        public OrderDetailHistoriesService()
        {
            _context = new SuperMContext();
        }

        public List<OrderDetailHistory> GetOrderDetailHistoriesList()
        {
            var orderDetailHistoriess = _context.OrderDetailHistories.ToList();
            return orderDetailHistoriess;
        }

        public OrderDetailHistory GetOrderDetailHistoriesById(int orderDetailHistoriesId)
        {
            OrderDetailHistory orderDetailHistory = _context.OrderDetailHistories.FirstOrDefault(x => x.OrderDetailHistoryId == orderDetailHistoriesId);
            return orderDetailHistory;
        }

        public void Add(OrderDetailHistory orderDetailHistories)
        {
            _context.OrderDetailHistories.Add(orderDetailHistories);
            _context.SaveChanges();
        }

        public void DeleteOrderDetailHistoriesById(int orderDetailHistoriesId)
        {
            OrderDetailHistory orderDetailHistories = GetOrderDetailHistoriesById(orderDetailHistoriesId);
            _context.OrderDetailHistories.Remove(orderDetailHistories);
            _context.SaveChanges();
        }

        public void UpdateOrderDetailHistoriesByOrderDetailHistories(OrderDetailHistory orderDetailHistory)
        {
            var OrderDetailHistories = GetOrderDetailHistoriesById(orderDetailHistory.OrderDetailHistoryId);
            if (OrderDetailHistories != null)
            {
            }
            _context.SaveChanges();
        }
    }
}

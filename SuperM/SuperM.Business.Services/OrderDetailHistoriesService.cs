namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderDetailHistoriesService
    {
        private SuperMContext Context;

        public OrderDetailHistoriesService()
        {
            Context = new SuperMContext();
        }

        public List<OrderDetailHistory> GetOrderDetailHistoriesList()
        {
            var orderDetailHistoriess = Context.OrderDetailHistories.ToList();
            return orderDetailHistoriess;
        }

        public OrderDetailHistory GetOrderDetailHistoriesById(int orderDetailHistoriesId)
        {
            OrderDetailHistory orderDetailHistory = Context.OrderDetailHistories.FirstOrDefault(x => x.OrderDetailHistoryId == orderDetailHistoriesId);
            return orderDetailHistory;
        }

        public void Add(OrderDetailHistory orderDetailHistories)
        {
            Context.OrderDetailHistories.Add(orderDetailHistories);
            Context.SaveChanges();
        }

        public void DeleteOrderDetailHistoriesById(int orderDetailHistoriesId)
        {
            OrderDetailHistory orderDetailHistories = GetOrderDetailHistoriesById(orderDetailHistoriesId);
            Context.OrderDetailHistories.Remove(orderDetailHistories);
            Context.SaveChanges();
        }

        public void UpdateOrderDetailHistoriesByOrderDetailHistories(OrderDetailHistory orderDetailHistory)
        {
            var OrderDetailHistories = GetOrderDetailHistoriesById(orderDetailHistory.OrderDetailHistoryId);
            if (OrderDetailHistories != null)
            {
            }
            Context.SaveChanges();
        }
    }
}

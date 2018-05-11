namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderHistoriesService
    {
        private SuperMContext Context;

        public OrderHistoriesService()
        {
            Context = new SuperMContext();
        }

        public List<OrderHistory> GetOrderHistoriesList()
        {
            var orderHistoriess = Context.OrderHistories.ToList();
            return orderHistoriess;
        }

        public OrderHistory GetOrderHistoriesById(int orderHistoriesId)
        {
            OrderHistory orderHistories = Context.OrderHistories.FirstOrDefault(x => x.OrderHistoryId == orderHistoriesId);
            return orderHistories;
        }

        public void Add(OrderHistory orderHistory)
        {
            Context.OrderHistories.Add(orderHistory);
            Context.SaveChanges();
        }

        public void DeleteOrderHistoriesById(int orderHistoriesId)
        {
            OrderHistory orderHistories = GetOrderHistoriesById(orderHistoriesId);
            Context.OrderHistories.Remove(orderHistories);
            Context.SaveChanges();
        }

        public void UpdateOrderHistoriesByOrderHistories(OrderHistory orderHistory)
        {
            var OrderHistories = GetOrderHistoriesById(orderHistory.OrderHistoryId);
            if (OrderHistories != null)
            {
            }
            Context.SaveChanges();
        }
    }
}

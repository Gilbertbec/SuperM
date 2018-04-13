
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
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

		//public List<OrderHistory> GetOrderHistoriesListByName(string name)
		//{
		//	var orderHistoriess = _context.OrderHistories.Where(x => x.Name.Contains(name)).ToList();
		//	return orderHistoriess;
		//}

		//public bool IsNameExisted(string name)
		//{
		//	bool isNameExisted = false;
		//	isNameExisted = (_context.OrderHistories.Count(x => x.Name == name) > 0);
		//	return isNameExisted;
		//}

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

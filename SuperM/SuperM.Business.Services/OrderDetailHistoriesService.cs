
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
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

		//public List<OrderDetailHistory> GetOrderDetailHistoriesListByName(string name)
		//{
		//	var orderDetailHistoriess = _context.OrderDetailHistories.Where(x => x..Contains(name)).ToList();
		//	return orderDetailHistoriess;
		//}

		//public bool IsNameExisted(string name)
		//{
		//	bool isNameExisted = false;
		//	isNameExisted = (_context.OrderDetailHistories.Count(x => x.Name == name) > 0);
		//	return isNameExisted;
		//}

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

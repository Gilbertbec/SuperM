
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class OrderDetailsService
	{
		private SuperMContext _context;

		public OrderDetailsService()
		{
			_context = new SuperMContext();
		}

		public List<OrderDetail> GetOrderDetailsList()
		{
			var orderDetailss = _context.OrderDetails.ToList();
			return orderDetailss;
		}

		public OrderDetail GetOrderDetailsById(int orderDetailsId)
		{
			OrderDetail orderDetails = _context.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailsId);
			return orderDetails;
		}

		public OrderDetail GetOrderDetailsByProductId(int productId)
		{
			OrderDetail orderDetails = _context.OrderDetails.SingleOrDefault(x => x.ProductId == productId);
			return orderDetails;
		}

		public OrderDetail GetOrderDetailsByOrderAndProductId(int orderId, int productId)
		{
			OrderDetail orderDetails = _context.OrderDetails.SingleOrDefault(x => x.ProductId == productId && x.OrderId == orderId);
			return orderDetails;
		}

		public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
		{
			List<OrderDetail> orderDetails = _context.OrderDetails.Where(x => x.OrderId == orderId).ToList();
			return orderDetails;
		}

		//public List<OrderDetail> GetOrderDetailsListByName(string name)
		//{
		//	var orderDetailss = _context.OrderDetails.Where(x => x.Name.Contains(name)).ToList();
		//	return orderDetailss;
		//}

		//public bool IsNameExisted(string name)
		//{
		//	bool isNameExisted = false;
		//	isNameExisted = (_context.OrderDetails.Count(x => x.Name == name) > 0);
		//	return isNameExisted;
		//}

		public void Add(OrderDetail orderDetails)
		{
			_context.OrderDetails.Add(orderDetails);
			_context.SaveChanges();
		}

		public void DeleteOrderDetailsById(int orderDetailsId)
		{
			OrderDetail orderDetails = GetOrderDetailsById(orderDetailsId);
			_context.OrderDetails.Remove(orderDetails);
			_context.SaveChanges();
		}

		public void UpdateOrderDetailsByOrderDetails(OrderDetail orderDetails)
		{
			var OrderDetails = GetOrderDetailsById(orderDetails.OrderDetailId);
			if (OrderDetails != null)
			{
			}
			_context.SaveChanges();
		}
	}
}

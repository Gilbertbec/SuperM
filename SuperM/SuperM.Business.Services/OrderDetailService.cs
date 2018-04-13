
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class OrderDetailService
	{
		private SuperMContext _context;

		public OrderDetailService()
		{
			_context = new SuperMContext();
		}

		public List<OrderDetail> GetOrderDetailList()
		{
			var orderDetails = _context.OrderDetails.ToList();
			return orderDetails;
		}

		public OrderDetail GetOrderDetailById(int orderDetailId)
		{
			OrderDetail orderDetail = _context.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailId);
			return orderDetail;
		}

		public void Add(OrderDetail orderDetail)
		{
			_context.OrderDetails.Add(orderDetail);
			_context.SaveChanges();
		}

		public void DeleteOrderDetailById(int orderDetailId)
		{
			OrderDetail orderDetail = GetOrderDetailById(orderDetailId);
			_context.OrderDetails.Remove(orderDetail);
			_context.SaveChanges();
		}

		public void UpdateOrderDetailByOrderDetail(OrderDetail orderDetail)
		{
			var OrderDetail = GetOrderDetailById(orderDetail.OrderDetailId);
			if (OrderDetail != null)
			{
				OrderDetail.OrderDetailId = orderDetail.OrderDetailId;
				OrderDetail.OrderId = orderDetail.OrderId;
				OrderDetail.Order = orderDetail.Order;
				OrderDetail.ProductId = orderDetail.ProductId;
				OrderDetail.Product = orderDetail.Product;
				OrderDetail.Discount = orderDetail.Discount;
				OrderDetail.Price = orderDetail.Price;
				OrderDetail.Quantity = orderDetail.Quantity;
				OrderDetail.NationTax = orderDetail.NationTax;
				OrderDetail.ProvinceTax = orderDetail.ProvinceTax;
			}
			_context.SaveChanges();
		}
	}
}

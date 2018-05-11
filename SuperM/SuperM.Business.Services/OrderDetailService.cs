namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderDetailService
    {
        private SuperMContext Context;

        public OrderDetailService()
        {
            Context = new SuperMContext();
        }

        public List<OrderDetail> GetOrderDetailList()
        {
            var orderDetails = Context.OrderDetails.ToList();
            return orderDetails;
        }

        public OrderDetail GetOrderDetailById(int orderDetailId)
        {
            OrderDetail orderDetail = Context.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailId);
            return orderDetail;
        }

        public void Add(OrderDetail orderDetail)
        {
            Context.OrderDetails.Add(orderDetail);
            Context.SaveChanges();
        }

        public void DeleteOrderDetailById(int orderDetailId)
        {
            OrderDetail orderDetail = GetOrderDetailById(orderDetailId);
            Context.OrderDetails.Remove(orderDetail);
            Context.SaveChanges();
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
            Context.SaveChanges();
        }
    }
}

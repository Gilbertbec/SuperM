namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderDetailsService
    {
        private SuperMContext Context;

        public OrderDetailsService()
        {
            Context = new SuperMContext();
        }

        public List<OrderDetail> GetOrderDetailsList()
        {
            var orderDetailss = Context.OrderDetails.ToList();
            return orderDetailss;
        }

        public OrderDetail GetOrderDetailsById(int orderDetailsId)
        {
            OrderDetail orderDetails = Context.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailsId);
            return orderDetails;
        }

        public OrderDetail GetOrderDetailsByProductId(int productId)
        {
            OrderDetail orderDetails = Context.OrderDetails.SingleOrDefault(x => x.ProductId == productId);
            return orderDetails;
        }

        public OrderDetail GetOrderDetailsByOrderAndProductId(int orderId, int productId)
        {
            OrderDetail orderDetails = Context.OrderDetails.SingleOrDefault(x => x.ProductId == productId && x.OrderId == orderId);
            return orderDetails;
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            List<OrderDetail> orderDetails = Context.OrderDetails.Where(x => x.OrderId == orderId).ToList();
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
            Context.OrderDetails.Add(orderDetails);
            Context.SaveChanges();
        }

        public void DeleteOrderDetailsById(int orderDetailsId)
        {
            OrderDetail orderDetails = GetOrderDetailsById(orderDetailsId);
            Context.OrderDetails.Remove(orderDetails);
            Context.SaveChanges();
        }

        public void UpdateOrderDetailsByOrderDetails(OrderDetail orderDetails)
        {
            var OrderDetails = GetOrderDetailsById(orderDetails.OrderDetailId);
            if (OrderDetails != null)
            {
            }
            Context.SaveChanges();
        }
    }
}

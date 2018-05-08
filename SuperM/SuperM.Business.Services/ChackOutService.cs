namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ChackOutService
    {
        private SuperMContext _context;

        readonly decimal NationTaxRate = 0.07M;

        readonly decimal ProvinceTaxRate = 0.05M;

        OrdersService orderService = new OrdersService();

        OrderDetailsService orderDetailsService = new OrderDetailsService();

        InventoryService inventoryService = new InventoryService();

        public ChackOutService()
        {
            _context = new SuperMContext();
        }

        public List<Product> GetProductList()
        {
            List<Product> products = _context.Inventories.Where(x => x.Count >= 0).Select(x => x.Product).ToList();
            return products;
        }

        public int GetNewOrderId(Order order)
        {
            orderService.Add(order);
            return order.OrderId;
        }

        public void AddProduct(Product product, int orderId, int quantity)
        {
            var orderDetail = orderDetailsService.GetOrderDetailsByOrderAndProductId(orderId, product.ProductId);
            if (orderDetail == null)
            {
                OrderDetail newOrderDetail = new OrderDetail
                {
                    OrderId = orderId,
                    ProductId = product.ProductId,
                    Price = product.SellingPrice,
                    Quantity = quantity,
                    NationTax = product.SellingPrice * NationTaxRate,
                    ProvinceTax = product.SellingPrice * ProvinceTaxRate
                };
                orderDetailsService.Add(newOrderDetail);
            }
            else
            {
                orderDetail.Quantity += quantity;
                orderDetail.NationTax += product.SellingPrice * NationTaxRate;
                orderDetail.ProvinceTax += product.SellingPrice * ProvinceTaxRate;
                orderDetailsService.UpdateOrderDetailsByOrderDetails(orderDetail);
            }
        }

        public void RomoveProduct(Product product, int orderId, int quantity)
        {
            var orderDetail = orderDetailsService.GetOrderDetailsByOrderAndProductId(orderId, product.ProductId);
            if (orderDetail != null && orderDetail.Quantity > quantity)
            {
                orderDetail.Quantity -= quantity;
                orderDetail.NationTax -= product.SellingPrice * NationTaxRate;
                orderDetail.ProvinceTax -= product.SellingPrice * ProvinceTaxRate;
                orderDetailsService.UpdateOrderDetailsByOrderDetails(orderDetail);
            }
        }

        public OrderAndOrderDetailForCheckOut CheckOut(int orderId)
        {
            OrderAndOrderDetailForCheckOut orderAndOrderDetailForCheckOut = new Data.Entities.OrderAndOrderDetailForCheckOut();


            Order order = orderService.GetOrdersById(orderId);
            List<OrderDetail> orderDetals = orderDetailsService.GetOrderDetailsByOrderId(orderId);

            orderAndOrderDetailForCheckOut.Order = order;
            orderAndOrderDetailForCheckOut.OrderDetail = orderDetals;

            decimal grossTotal = 0;
            decimal nationTax = 0;
            decimal provinceTax = 0;
            foreach (var item in orderDetals)
            {
                grossTotal += item.Price * item.Quantity;
                nationTax += item.NationTax;
                provinceTax += item.ProvinceTax;
                inventoryService.SaleOut((int)item.ProductId, item.Quantity);
            }
            order.GrossTotal = grossTotal;
            order.NationTax = nationTax;
            order.ProvinceTax = provinceTax;
            order.Total = grossTotal + nationTax + provinceTax;
            orderService.UpdateOrdersByOrder(order);

            return orderAndOrderDetailForCheckOut;
        }
    }
}

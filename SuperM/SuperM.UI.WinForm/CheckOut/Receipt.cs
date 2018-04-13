﻿using SuperM.Business.Services;
using SuperM.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperM.UI.WinForm.CheckOut
{
	public partial class Receipt : Form
	{
		OrderService _orderService = new OrderService();
		OrderDetailService _orderDetailService = new OrderDetailService();

		public Receipt()
		{
			InitializeComponent();
		}

		public Receipt(OrderAndOrderDetailForCheckOut checkOut)
		{
			InitializeComponent();

			txtOrderId.Text = checkOut.Order.OrderId.ToString();
			txtUserId.Text = checkOut.Order.UserId.ToString();
			txtOrderTime.Text = checkOut.Order.OrderTime.ToString();
			txtGrossTotal.Text = checkOut.Order.GrossTotal.ToString();
			txtNationTax.Text = checkOut.Order.NationTax.ToString();
			txtProvinceTax.Text = checkOut.Order.ProvinceTax.ToString();
			txtTotal.Text = checkOut.Order.Total.ToString();

			txtOrderDetailId.Text = checkOut.OrderDetail[0].OrderDetailId.ToString();
			txtProductId.Text = checkOut.OrderDetail[0].ProductId.ToString();
			//txtProduct.Text = checkOut.OrderDetail[0].Product.ToString();
			txtDiscount.Text = checkOut.OrderDetail[0].Discount.ToString();
			txtPrice.Text = checkOut.OrderDetail[0].Price.ToString();
			txtQuantity.Text = checkOut.OrderDetail[0].Quantity.ToString();
			txtNationTaxDetail.Text = checkOut.OrderDetail[0].NationTax.ToString();
			txtProvinceTaxDetail.Text = checkOut.OrderDetail[0].ProvinceTax.ToString();

			Order order = _orderService.GetOrderById(checkOut.Order.OrderId);
			dgvOrder.DataSource = new List<Order> { order };
			dgvOrderDetails.DataSource = checkOut.OrderDetail;
		}
	}
}
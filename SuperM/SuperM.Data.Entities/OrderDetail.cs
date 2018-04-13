using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class OrderDetail
	{
		public int OrderDetailId { get; set; }

		public int OrderId { get; set; }

		public Order Order { get; set; }

		public int? ProductId { get; set; }

		public virtual Product Product { get; set; }

		public decimal Discount { get; set; }

		public decimal Price { get; set; }

		public int Quantity { get; set; }

		public decimal NationTax { get; set; }

		public decimal ProvinceTax { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class OrderDetailHistory
	{
		public int OrderDetailHistoryId { get; set; }

		public int? OrderHistoryId { get; set; }

		public virtual OrderHistory OrderHistory { get; set; }

		public int ProductHistoryId { get; set; }

		public virtual ProductHistory Product { get; set; }

		public decimal Discount { get; set; }

		public decimal Price { get; set; }

		public int Quantity { get; set; }

		public decimal NationTax { get; set; }

		public decimal ProvinceTax { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class ShoppingCart
	{
		public int ShoppingCartId { get; set; }

		public int CustomerId { get; set; }

		public int ProductId { get; set; }

		public virtual Product Product { get; set; }

		public int QuantityToBuy { get; set; }

	}
}

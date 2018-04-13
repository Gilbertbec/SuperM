using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class OrderAndOrderDetailForCheckOut
	{
		public Order Order { get; set; }
		public List<OrderDetail> OrderDetail {get; set;}
	}
}

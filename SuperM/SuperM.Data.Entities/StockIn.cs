using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class StockIn
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StockInId { get; set; }

		public string Batch { get; set; }

		public int Count { get; set; }

		public int ProductId { get; set; }

		public virtual Product Product { get; set; }

		public decimal Subtotal { get; set; }

		public int? UserId { get; set; }

		[ForeignKey("UserId")]
		public virtual User User { get; set; }

		public DateTime InStockTime { get; set; }
	}
}

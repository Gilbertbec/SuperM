using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class ProductHistory
	{
		public int ProductHistoryId { get; set; }

		public int ProductId { get; set; }

		[Required]
		public string Name { get; set; }

		public string Specification { get; set; }

		public int? CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }

		public string Description { get; set; }

		public decimal PurchasedPrice { get; set; }

		public decimal SellingPrice { get; set; }

		public int? SupplierId { get; set; }

		[ForeignKey("SupplierId")]
		public virtual Supplier Supplier { get; set; }

		public DateTime ExpirationDate { get; set; }

		public DateTime PurchasedDate { get; set; }
	}
}

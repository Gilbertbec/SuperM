namespace SuperM.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Specification { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Description { get; set; }

        public decimal PurchasedPrice { get; set; }

        public decimal SellingPrice { get; set; }

        public int? SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}

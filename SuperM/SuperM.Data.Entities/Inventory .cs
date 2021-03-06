﻿namespace SuperM.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryId { get; set; }

        public string Batch { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public int? ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public int? SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        public int? StockInId { get; set; }

        [ForeignKey("StockInId")]
        public virtual StockIn StockIn { get; set; }

        public DateTime InStockTime { get; set; }
    }
}

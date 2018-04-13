namespace SuperM.Data.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StockIns", "ProductId", "dbo.Products");
            DropForeignKey("dbo.StockIns", "UserId", "dbo.Users");
            DropForeignKey("dbo.ActualInventories", "InventoryId", "dbo.StockIns");
            DropForeignKey("dbo.ActualInventories", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ActualInventories", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.ActualInventories", new[] { "ProductId" });
            DropIndex("dbo.ActualInventories", new[] { "SupplierId" });
            DropIndex("dbo.ActualInventories", new[] { "InventoryId" });
            DropIndex("dbo.StockIns", new[] { "ProductId" });
            DropIndex("dbo.StockIns", new[] { "UserId" });
            DropTable("dbo.ActualInventories");
            DropTable("dbo.StockIns");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StockIns",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserId = c.Int(),
                        InStockTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId);
            
            CreateTable(
                "dbo.ActualInventories",
                c => new
                    {
                        ActualInventoryId = c.Int(nullable: false, identity: true),
                        Batch = c.String(),
                        Count = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductId = c.Int(),
                        SupplierId = c.Int(),
                        InventoryId = c.Int(),
                        InStockTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ActualInventoryId);
            
            CreateIndex("dbo.StockIns", "UserId");
            CreateIndex("dbo.StockIns", "ProductId");
            CreateIndex("dbo.ActualInventories", "InventoryId");
            CreateIndex("dbo.ActualInventories", "SupplierId");
            CreateIndex("dbo.ActualInventories", "ProductId");
            AddForeignKey("dbo.ActualInventories", "SupplierId", "dbo.Suppliers", "SupplierId");
            AddForeignKey("dbo.ActualInventories", "ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.ActualInventories", "InventoryId", "dbo.StockIns", "InventoryId");
            AddForeignKey("dbo.StockIns", "UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.StockIns", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
    }
}

namespace SuperM.Data.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Order_OrderDetail_Receipt_OrderHistory_OrderDetailHistory_ProductHistroy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetailHistories",
                c => new
                    {
                        OrderDetailHistoryId = c.Int(nullable: false, identity: true),
                        OrderHistoryId = c.Int(),
                        ProductHistoryId = c.Int(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        NationTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProvinceTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailHistoryId)
                .ForeignKey("dbo.OrderHistories", t => t.OrderHistoryId)
                .ForeignKey("dbo.ProductHistories", t => t.ProductHistoryId, cascadeDelete: true)
                .Index(t => t.OrderHistoryId)
                .Index(t => t.ProductHistoryId);
            
            CreateTable(
                "dbo.OrderHistories",
                c => new
                    {
                        OrderHistoryId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        OrderTime = c.DateTime(nullable: false),
                        GrossTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NationTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProvinceTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderHistoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        NationTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProvinceTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderHistory_OrderHistoryId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.OrderHistories", t => t.OrderHistory_OrderHistoryId)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId)
                .Index(t => t.OrderHistory_OrderHistoryId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OrderTime = c.DateTime(nullable: false),
                        GrossTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NationTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProvinceTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.ProductHistories",
                c => new
                    {
                        ProductHistoryId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Specification = c.String(),
                        CategoryId = c.Int(),
                        Description = c.String(),
                        PurchasedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SupplierId = c.Int(),
                        ExpirationDate = c.DateTime(nullable: false),
                        PurchasedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductHistoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.CategoryId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptId = c.Int(nullable: false, identity: true),
                        ReceiptContent = c.String(),
                    })
                .PrimaryKey(t => t.ReceiptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetailHistories", "ProductHistoryId", "dbo.ProductHistories");
            DropForeignKey("dbo.ProductHistories", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ProductHistories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.OrderDetailHistories", "OrderHistoryId", "dbo.OrderHistories");
            DropForeignKey("dbo.OrderDetails", "OrderHistory_OrderHistoryId", "dbo.OrderHistories");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductHistories", new[] { "SupplierId" });
            DropIndex("dbo.ProductHistories", new[] { "CategoryId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderHistory_OrderHistoryId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.OrderDetailHistories", new[] { "ProductHistoryId" });
            DropIndex("dbo.OrderDetailHistories", new[] { "OrderHistoryId" });
            DropTable("dbo.Receipts");
            DropTable("dbo.ProductHistories");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.OrderHistories");
            DropTable("dbo.OrderDetailHistories");
        }
    }
}

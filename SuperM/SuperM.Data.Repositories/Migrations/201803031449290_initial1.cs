namespace SuperM.Data.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockIns",
                c => new
                    {
                        StockInId = c.Int(nullable: false, identity: true),
                        Batch = c.String(),
                        Count = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserId = c.Int(),
                        InStockTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StockInId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockIns", "UserId", "dbo.Users");
            DropForeignKey("dbo.StockIns", "ProductId", "dbo.Products");
            DropIndex("dbo.StockIns", new[] { "UserId" });
            DropIndex("dbo.StockIns", new[] { "ProductId" });
            DropTable("dbo.StockIns");
        }
    }
}

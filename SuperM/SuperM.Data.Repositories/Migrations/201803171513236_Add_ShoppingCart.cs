namespace SuperM.Data.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ShoppingCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        ShoppingCartId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        PruductId = c.Int(nullable: false),
                        QuantityToBuy = c.Int(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ShoppingCartId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCarts", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ShoppingCarts", new[] { "Product_ProductId" });
            DropTable("dbo.ShoppingCarts");
        }
    }
}

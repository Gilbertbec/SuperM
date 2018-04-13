namespace SuperM.Data.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modify_ProductId_In_ShoppingCart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingCarts", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ShoppingCarts", new[] { "Product_ProductId" });
            RenameColumn(table: "dbo.ShoppingCarts", name: "Product_ProductId", newName: "ProductId");
            AlterColumn("dbo.ShoppingCarts", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.ShoppingCarts", "ProductId");
            AddForeignKey("dbo.ShoppingCarts", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            DropColumn("dbo.ShoppingCarts", "PruductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShoppingCarts", "PruductId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ShoppingCarts", "ProductId", "dbo.Products");
            DropIndex("dbo.ShoppingCarts", new[] { "ProductId" });
            AlterColumn("dbo.ShoppingCarts", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.ShoppingCarts", name: "ProductId", newName: "Product_ProductId");
            CreateIndex("dbo.ShoppingCarts", "Product_ProductId");
            AddForeignKey("dbo.ShoppingCarts", "Product_ProductId", "dbo.Products", "ProductId");
        }
    }
}

namespace SuperM.Data.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_OrderHistory_OrderDetailHistories : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "OrderHistory_OrderHistoryId", "dbo.OrderHistories");
            DropIndex("dbo.OrderDetails", new[] { "OrderHistory_OrderHistoryId" });
            DropColumn("dbo.OrderDetails", "OrderHistory_OrderHistoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderDetails", "OrderHistory_OrderHistoryId", c => c.Int());
            CreateIndex("dbo.OrderDetails", "OrderHistory_OrderHistoryId");
            AddForeignKey("dbo.OrderDetails", "OrderHistory_OrderHistoryId", "dbo.OrderHistories", "OrderHistoryId");
        }
    }
}

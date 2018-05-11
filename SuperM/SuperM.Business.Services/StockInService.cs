namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class StockInService
    {
        private SuperMContext Context;

        public StockInService()
        {
            Context = new SuperMContext();
        }

        public dynamic GetInventoryList()
        {
            var inventorys = Context.StockIns.Select(x => new { x.StockInId, x.Batch, ProductName = x.Product.Name, x.Count, x.Subtotal, UserName = x.User.Name, x.InStockTime }).ToList();
            return inventorys;
        }

        public StockIn GetInventoryById(int inventoryId)
        {
            StockIn inventory = Context.StockIns.FirstOrDefault(x => x.StockInId == inventoryId);
            return inventory;
        }

        public List<StockIn> GetInventoryListByName(string name)
        {
            var inventorys = Context.StockIns.Where(x => x.Batch.Contains(name)).ToList();
            return inventorys;
        }

        public List<StockIn> GetInventoryListByProductId(int productId)
        {
            List<StockIn> inventorys = Context.StockIns.Where(x => x.ProductId == productId).ToList();
            return inventorys;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.StockIns.Count(x => x.Batch == name) > 0);
            return isNameExisted;
        }

        public int Add(StockIn stockIn)
        {
            Context.StockIns.Add(stockIn);
            Context.SaveChanges();
            return stockIn.StockInId;
        }

        public void DeleteInventoryById(int inventoryId)
        {
            StockIn inventory = GetInventoryById(inventoryId);
            Context.StockIns.Remove(inventory);
            Context.SaveChanges();
        }

        public void UpdateInventoryByInventory(StockIn inventory)
        {
            var oldInventory = GetInventoryById(inventory.StockInId);
            if (oldInventory != null)
            {
                oldInventory.Batch = inventory.Batch;
                oldInventory.Count = inventory.Count;
                oldInventory.ProductId = inventory.ProductId;
            }
            Context.SaveChanges();
        }

        public void UpdateInventoryCount(int inventroyId, int count)
        {
            var inventory = GetInventoryById(inventroyId);
            if (inventory != null)
            {
                inventory.Count = count;
            }
            Context.SaveChanges();
        }
    }
}

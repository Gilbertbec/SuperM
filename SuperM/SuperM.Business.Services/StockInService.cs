
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class StockInService
	{
		private SuperMContext _context;

		public StockInService()
		{
			_context = new SuperMContext();
		}

		public dynamic GetInventoryList()
		{
			var inventorys = _context.StockIns.Select(x => new { x.StockInId, x.Batch, ProductName = x.Product.Name, x.Count,x.Subtotal, UserName = x.User.Name, x.InStockTime}).ToList();
			return inventorys;
		}

		public StockIn GetInventoryById(int inventoryId)
		{
			StockIn inventory = _context.StockIns.FirstOrDefault(x => x.StockInId == inventoryId);
			return inventory;
		}

		public List<StockIn> GetInventoryListByName(string name)
		{
			var inventorys = _context.StockIns.Where(x => x.Batch.Contains(name)).ToList();
			return inventorys;
		}

		public List<StockIn> GetInventoryListByProductId(int productId)
		{
			List<StockIn> inventorys = _context.StockIns.Where(x => x.ProductId == productId).ToList();
			return inventorys;
		}

		public bool IsNameExisted(string name)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.StockIns.Count(x => x.Batch == name) > 0);
			return isNameExisted;
		}

		public int Add(StockIn stockIn)
		{
			_context.StockIns.Add(stockIn);
			_context.SaveChanges();
			return stockIn.StockInId;
		}

		public void DeleteInventoryById(int inventoryId)
		{
			StockIn inventory = GetInventoryById(inventoryId);
			_context.StockIns.Remove(inventory);
			_context.SaveChanges();
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
			_context.SaveChanges();
		}

		public void UpdateInventoryCount(int inventroyId, int count)
		{
			var inventory = GetInventoryById(inventroyId);
			if (inventory != null)
			{
				inventory.Count = count;
			}
			_context.SaveChanges();
		}
	}
}

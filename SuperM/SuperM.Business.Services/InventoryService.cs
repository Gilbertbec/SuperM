
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class InventoryService
	{
		private SuperMContext _context;

		public InventoryService()
		{
			_context = new SuperMContext();
		}

		public List<Inventory> GetInventoryList()
		{
			var inventorys = _context.Inventories.Where(x => x.Price > 0).ToList();
			return inventorys;
		}

		public Inventory GetInventoryById(int inventoryId)
		{
			Inventory inventory = _context.Inventories.FirstOrDefault(x => x.InventoryId == inventoryId);
			return inventory;
		}

		public List<Inventory> GetInventoryListByName(string name)
		{
			var inventorys = _context.Inventories.Where(x => x.Batch.Contains(name)).ToList();
			return inventorys;
		}

		public Inventory GetInventoryByProductId(int productId)
		{
			Inventory inventory = _context.Inventories.SingleOrDefault(x => x.ProductId == productId);
			return inventory;
		}

		public Inventory GetInventoryByProductIdAndSupplierId(int productId, int supplierId)
		{
			Inventory inventory = _context.Inventories.SingleOrDefault(x => x.ProductId == productId && x.SupplierId == supplierId);
			return inventory;
		}

		public bool IsNameExisted(string name)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.Inventories.Count(x => x.Batch == name) > 0);
			return isNameExisted;
		}

		public bool IsProductAndSupplierExisted(Inventory inventory)
		{
			bool isProductAndSupplierExisted = false;
			isProductAndSupplierExisted = (_context.Inventories.Count(x => x.ProductId == inventory.ProductId && x.SupplierId == inventory.SupplierId) > 0);
			return isProductAndSupplierExisted;
		}

		public void Add(Inventory inventory)
		{
			if (!IsProductAndSupplierExisted(inventory))
			{
				_context.Inventories.Add(inventory);
			}
			else
			{
				Inventory currentInventory = GetInventoryByProductIdAndSupplierId((int)inventory.ProductId, (int)inventory.SupplierId);
				if (currentInventory != null)
				{ 
					currentInventory.Count += inventory.Count;
				}

			}
			_context.SaveChanges();
		}

		public void DeleteInventoryById(int inventoryId)
		{
			Inventory inventory = GetInventoryById(inventoryId);
			_context.Inventories.Remove(inventory);
			_context.SaveChanges();
		}

		//public void SubtractProductQuantityByProductId(int inventoryId)
		//{
		//	Inventory inventory = GetInventoryById(inventoryId);
		//	_context.Inventories.Remove(inventory);
		//	_context.SaveChanges();
		//}

		public void SaleOut(int productId, int Quantity)
		{
			var Inventory = GetInventoryByProductId(productId);
			if (Inventory != null)
			{
				Inventory.Count -= Quantity;
			}
			_context.SaveChanges();


		}

		public void UpdateInventoryByInventory(Inventory inventory)
		{
			var Inventory = GetInventoryById(inventory.InventoryId);
			if (Inventory != null)
			{
				Inventory.InventoryId = inventory.InventoryId;
				Inventory.Batch = inventory.Batch;
				Inventory.Count = inventory.Count;
				Inventory.Price = inventory.Price;
				Inventory.ProductId = inventory.ProductId;
				Inventory.Product = inventory.Product;
				Inventory.SupplierId = inventory.SupplierId;
				Inventory.Supplier = inventory.Supplier;
				Inventory.StockInId = inventory.StockInId;
				Inventory.StockIn = inventory.StockIn;
				Inventory.InStockTime = inventory.InStockTime;
			}
			_context.SaveChanges();
		}
	}
}

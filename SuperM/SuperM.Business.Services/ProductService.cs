namespace SuperM.Business.Services
{
	using SuperM.Data.Entities;
	using SuperM.Data.Repositories;
	using System.Collections.Generic;
	using System.Linq;

	public class ProductService
	{
		/// <summary>
		/// 
		/// </summary>
		private SuperMContext _context;

		public ProductService()
		{
			_context = new SuperMContext();
		}

		public dynamic GetProductList()
		{
			var products = _context.Products.Select(x => new { x.ProductId, x.Name, x.Specification, CategoryName = x.Category.Name, SupplierName = x.Supplier.Name,x.PurchasedPrice,x.SellingPrice,x.PurchasedDate,x.ExpirationDate, x.Description}).ToList();
			return products;
		}

		public Product GetProductById(int productId)
		{
			var product = _context.Products.First(x => x.ProductId == productId);
			return product;
		}

		public List<Product> GetProductListById(int productId)
		{
			List<Product> product = _context.Products.Where(x => x.ProductId == productId).ToList();
			return product;
		}

		public List<Product> GetProductListByName(string name)
		{
			var products = _context.Products.Where(x => x.Name.Contains(name)).ToList();
			return products;
		}

		public bool IsNameExisted(string name)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.Products.Count(x => x.Name == name) > 0);
			return isNameExisted;
		}

		public void Add(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public void DeleteProductById(int productId)
		{
			Product product = GetProductById(productId);
			_context.Products.Remove(product);
			_context.SaveChanges();
		}

		public void UpdateProductByProduct(Product product)
		{
			var Product = GetProductById(product.ProductId);
			if (Product != null)
			{
				Product.ProductId = product.ProductId;
				Product.Name = product.Name;
				Product.Specification = product.Specification;
				Product.CategoryId = product.CategoryId;
				Product.Description = product.Description;
				Product.PurchasedPrice = product.PurchasedPrice;
				Product.SellingPrice = product.SellingPrice;
				Product.SupplierId = product.SupplierId;
				Product.ExpirationDate = product.ExpirationDate;
				Product.PurchasedDate = product.PurchasedDate;
			}
			_context.SaveChanges();
		}

		public List<Product> GetProductByPage(int pageIndex, int pageSize)
		{
			var productList = _context.Products.OrderByDescending(p => p.Name).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
			return productList;
		}
	}
}

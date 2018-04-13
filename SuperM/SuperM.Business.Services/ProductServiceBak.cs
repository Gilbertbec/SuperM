using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class ProductServiceBak
	{
		private SuperMContext _context;

		public ProductServiceBak()
		{
			_context = new SuperMContext();
		}

		public void Add(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public Product GetProductById(int productId)
		{
			Product product = _context.Products.FirstOrDefault(i => i.ProductId == productId); 
			return product;
		}

		public void DeleteProductById(int productId)
		{
			Product product = GetProductById(productId);
			_context.Products.Remove(product);
			_context.SaveChanges();
		}

		public void UpdateProductByProduct(Product p_product)
		{
			Product product = GetProductById(p_product.ProductId);
			if(product != null)
			{
				product.Name = p_product.Name;
				product.Specification = p_product.Specification;
				product.PurchasedPrice = p_product.PurchasedPrice;
				product.SellingPrice = p_product.SellingPrice;
				product.Description = p_product.Description;
				product.SupplierId = p_product.SupplierId;
				product.ExpirationDate = p_product.ExpirationDate;
				product.PurchasedDate = p_product.PurchasedDate;
				product.CategoryId = p_product.CategoryId;
			}
			_context.SaveChanges();
		}

		public List<Product> GetProductList()
		{
			var products = _context.Products.ToList();
			return products;
		}
	}
}

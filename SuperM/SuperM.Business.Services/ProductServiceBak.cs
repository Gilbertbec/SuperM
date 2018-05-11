namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductServiceBak
    {
        private SuperMContext Context;

        public ProductServiceBak()
        {
            Context = new SuperMContext();
        }

        public void Add(Product product)
        {
            Context.Products.Add(product);
            Context.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            Product product = Context.Products.FirstOrDefault(i => i.ProductId == productId);
            return product;
        }

        public void DeleteProductById(int productId)
        {
            Product product = GetProductById(productId);
            Context.Products.Remove(product);
            Context.SaveChanges();
        }

        public void UpdateProductByProduct(Product p_product)
        {
            Product product = GetProductById(p_product.ProductId);
            if (product != null)
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
            Context.SaveChanges();
        }

        public List<Product> GetProductList()
        {
            var products = Context.Products.ToList();
            return products;
        }
    }
}

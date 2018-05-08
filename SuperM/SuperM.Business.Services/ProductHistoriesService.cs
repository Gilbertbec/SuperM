namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductHistoriesService
    {
        private SuperMContext _context;

        public ProductHistoriesService()
        {
            _context = new SuperMContext();
        }

        public List<ProductHistory> GetProductHistoriesList()
        {
            var productHistoriess = _context.ProductHistories.ToList();
            return productHistoriess;
        }

        public ProductHistory GetProductHistoriesById(int productHistoriesId)
        {
            ProductHistory productHistory = _context.ProductHistories.FirstOrDefault(x => x.ProductHistoryId == productHistoriesId);
            return productHistory;
        }

        public List<ProductHistory> GetProductHistoriesListByName(string name)
        {
            var productHistoriess = _context.ProductHistories.Where(x => x.Name.Contains(name)).ToList();
            return productHistoriess;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (_context.ProductHistories.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(ProductHistory productHistory)
        {
            _context.ProductHistories.Add(productHistory);
            _context.SaveChanges();
        }

        public void DeleteProductHistoriesById(int productHistoriesId)
        {
            ProductHistory productHistories = GetProductHistoriesById(productHistoriesId);
            _context.ProductHistories.Remove(productHistories);
            _context.SaveChanges();
        }

        public void UpdateProductHistoriesByProductHistories(ProductHistory productHistory)
        {
            var ProductHistories = GetProductHistoriesById(productHistory.ProductHistoryId);
            if (ProductHistories != null)
            {
            }
            _context.SaveChanges();
        }
    }
}

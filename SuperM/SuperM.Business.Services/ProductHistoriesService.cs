namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductHistoriesService
    {
        private SuperMContext Context;

        public ProductHistoriesService()
        {
            Context = new SuperMContext();
        }

        public List<ProductHistory> GetProductHistoriesList()
        {
            var productHistoriess = Context.ProductHistories.ToList();
            return productHistoriess;
        }

        public ProductHistory GetProductHistoriesById(int productHistoriesId)
        {
            ProductHistory productHistory = Context.ProductHistories.FirstOrDefault(x => x.ProductHistoryId == productHistoriesId);
            return productHistory;
        }

        public List<ProductHistory> GetProductHistoriesListByName(string name)
        {
            var productHistoriess = Context.ProductHistories.Where(x => x.Name.Contains(name)).ToList();
            return productHistoriess;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.ProductHistories.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(ProductHistory productHistory)
        {
            Context.ProductHistories.Add(productHistory);
            Context.SaveChanges();
        }

        public void DeleteProductHistoriesById(int productHistoriesId)
        {
            ProductHistory productHistories = GetProductHistoriesById(productHistoriesId);
            Context.ProductHistories.Remove(productHistories);
            Context.SaveChanges();
        }

        public void UpdateProductHistoriesByProductHistories(ProductHistory productHistory)
        {
            var ProductHistories = GetProductHistoriesById(productHistory.ProductHistoryId);
            if (ProductHistories != null)
            {
            }
            Context.SaveChanges();
        }
    }
}

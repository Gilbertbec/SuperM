namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductTypeService
    {
        private SuperMContext Context;

        public ProductTypeService()
        {
            Context = new SuperMContext();
        }

        public List<ProductType> GetAllProductType()
        {
            var productTypes = Context.ProductTypes.ToList();
            return productTypes;
        }

        public List<ProductType> GetProductTypeByName(string productTypeName)
        {
            var productTypes = Context.ProductTypes.Where(pt => pt.ProductTypeName.Contains(productTypeName)).ToList();
            return productTypes;
        }

        public bool IsProductTypeNameExisted(string productTypeName)
        {
            bool isProductTypeNameExisted = false;
            isProductTypeNameExisted = (Context.ProductTypes.Count(pt => pt.ProductTypeName == productTypeName) > 0);
            return isProductTypeNameExisted;
        }

        public void Add(ProductType productType)
        {
            Context.ProductTypes.Add(productType);
            Context.SaveChanges();
        }

        public void Delete(ProductType productType)
        {
            var currentProductType = Context.ProductTypes.FirstOrDefault(pt => pt.ProductTypeId == productType.ProductTypeId);
            if (currentProductType != null)
            {
                Context.ProductTypes.Remove(currentProductType);
                Context.SaveChanges();
            }
        }

        public void Update(ProductType productType)
        {
            var currentProductType = Context.ProductTypes.FirstOrDefault(pt => pt.ProductTypeId == productType.ProductTypeId);
            if (currentProductType != null)
            {
                currentProductType.ProductTypeName = productType.ProductTypeName;
                Context.SaveChanges();
            }
        }
    }
}

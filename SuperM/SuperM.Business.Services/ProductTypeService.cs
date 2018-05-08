namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductTypeService
    {
        private SuperMContext _context;

        public ProductTypeService()
        {
            _context = new SuperMContext();
        }

        public List<ProductType> GetAllProductType()
        {
            var productTypes = _context.ProductTypes.ToList();
            return productTypes;
        }

        public List<ProductType> GetProductTypeByName(string productTypeName)
        {
            var productTypes = _context.ProductTypes.Where(pt => pt.ProductTypeName.Contains(productTypeName)).ToList();
            return productTypes;
        }

        public bool IsProductTypeNameExisted(string productTypeName)
        {
            bool isProductTypeNameExisted = false;
            isProductTypeNameExisted = (_context.ProductTypes.Count(pt => pt.ProductTypeName == productTypeName) > 0);
            return isProductTypeNameExisted;
        }

        public void Add(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            _context.SaveChanges();
        }

        public void Delete(ProductType productType)
        {
            var currentProductType = _context.ProductTypes.FirstOrDefault(pt => pt.ProductTypeId == productType.ProductTypeId);
            if (currentProductType != null)
            {
                _context.ProductTypes.Remove(currentProductType);
                _context.SaveChanges();
            }
        }

        public void Update(ProductType productType)
        {
            var currentProductType = _context.ProductTypes.FirstOrDefault(pt => pt.ProductTypeId == productType.ProductTypeId);
            if (currentProductType != null)
            {
                currentProductType.ProductTypeName = productType.ProductTypeName;
                _context.SaveChanges();
            }
        }
    }
}

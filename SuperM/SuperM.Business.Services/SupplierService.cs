namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class SupplierService
    {
        private SuperMContext Context;

        public SupplierService()
        {
            Context = new SuperMContext();
        }

        public List<Supplier> GetSupplierList()
        {
            var suppliers = Context.Suppliers.ToList();
            return suppliers;
        }

        public Supplier GetSupplierById(int supplierId)
        {
            Supplier supplier = Context.Suppliers.FirstOrDefault(x => x.SupplierId == supplierId);
            return supplier;
        }

        public List<Supplier> GetSupplierListByName(string name)
        {
            var suppliers = Context.Suppliers.Where(x => x.Name.Contains(name)).ToList();
            return suppliers;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Suppliers.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Supplier supplier)
        {
            Context.Suppliers.Add(supplier);
            Context.SaveChanges();
        }

        public void DeleteSupplierById(int supplierId)
        {
            Supplier supplier = GetSupplierById(supplierId);
            Context.Suppliers.Remove(supplier);
            Context.SaveChanges();
        }

        public void UpdateSupplierBySupplier(Supplier supplier)
        {
            var Supplier = GetSupplierById(supplier.SupplierId);
            if (Supplier != null)
            {
                Supplier.SupplierId = supplier.SupplierId;
                Supplier.Name = supplier.Name;
                Supplier.Address = supplier.Address;
                Supplier.TelephoneNumber = supplier.TelephoneNumber;
                Supplier.Fax = supplier.Fax;
                Supplier.Email = supplier.Email;
                Supplier.Website = supplier.Website;
                Supplier.Rank = supplier.Rank;
            }
            Context.SaveChanges();
        }
    }
}

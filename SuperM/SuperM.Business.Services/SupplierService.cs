
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class SupplierService
	{
		private SuperMContext _context;

		public SupplierService()
		{
			_context = new SuperMContext();
		}

		public List<Supplier> GetSupplierList()
		{
			var suppliers = _context.Suppliers.ToList();
			return suppliers;
		}

		public Supplier GetSupplierById(int supplierId)
		{
			Supplier supplier = _context.Suppliers.FirstOrDefault(x => x.SupplierId == supplierId);
			return supplier;
		}

		public List<Supplier> GetSupplierListByName(string name)
		{
			var suppliers = _context.Suppliers.Where(x => x.Name.Contains(name)).ToList();
			return suppliers;
		}

		public bool IsNameExisted(string name)
		{
			bool isNameExisted = false;
			isNameExisted = (_context.Suppliers.Count(x => x.Name == name) > 0);
			return isNameExisted;
		}

		public void Add(Supplier supplier)
		{
			_context.Suppliers.Add(supplier);
			_context.SaveChanges();
		}

		public void DeleteSupplierById(int supplierId)
		{
			Supplier supplier = GetSupplierById(supplierId);
			_context.Suppliers.Remove(supplier);
			_context.SaveChanges();
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
			_context.SaveChanges();
		}
	}
}

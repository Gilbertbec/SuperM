using SuperM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Repositories
{
	public class SuperMContext:DbContext
	{
		public SuperMContext() : base("name=SuperMConnectionString")
		{ }

		public SuperMContext(string connectionString) : base(connectionString)
		{ }

		public DbSet<Product> Products { get; set; }

		public DbSet<ProductType> ProductTypes { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Supplier> Suppliers { get; set; }

		public DbSet<User> Users { get; set; } 

		public DbSet<Group> Groups { get; set; }

		public DbSet<UserGroup> UserGroups { get; set; }

		public DbSet<StockIn> StockIns { get; set; }

		public DbSet<Company> Companies { get; set; }

		public DbSet<Department> Departments { get; set; }

		public DbSet<Position> Positions { get; set; }

		public DbSet<Employee> Employees { get; set; }

		public DbSet<Permission> Permissions { get; set; }

		public DbSet<Inventory> Inventories { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<Receipt> Receipts { get; set; }

		public DbSet<OrderHistory> OrderHistories { get; set; }

		public DbSet<OrderDetailHistory> OrderDetailHistories { get; set; }

		public DbSet<ProductHistory> ProductHistories { get; set; }

		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
	}
}

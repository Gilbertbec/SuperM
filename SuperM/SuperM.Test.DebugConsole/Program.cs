namespace SuperM.Test.DebugConsole
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			ProductServiceBak productServeice = new ProductServiceBak();

			Product product = new Product()
			{
				Name = "中华牙膏3",
				Specification = "v.2008",
				PurchasedPrice = 11,
				SellingPrice = 20,
				Description = "good product",
				SupplierId = 1,
				ExpirationDate = DateTime.Now,
				PurchasedDate = DateTime.Now,
				CategoryId = 1
			};

			productServeice.Add(product);

			Product product1 = productServeice.GetProductById(2);
			Console.WriteLine(product1.Name);

			Console.ReadKey();

		}
	}
}

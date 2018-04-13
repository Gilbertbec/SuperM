
using SuperM.Data.Entities;
using SuperM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class ShoppingCartService
	{
		private SuperMContext _context;

		public ShoppingCartService()
		{
			_context = new SuperMContext();
		}

		public List<ShoppingCart> GetShoppingCartList()
		{
			var shoppingCarts = _context.ShoppingCarts.ToList();
			return shoppingCarts;
		}

		public ShoppingCart GetShoppingCartById(int shoppingCartId)
		{
			ShoppingCart shoppingCart = _context.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartId == shoppingCartId);
			return shoppingCart;
		}

		public List<ShoppingCart> GetShoppingCartByCustomerId(int customerId)
		{
			List<ShoppingCart> shoppingCarts = _context.ShoppingCarts.Where(x => x.CustomerId == customerId).ToList();
			return shoppingCarts;
		}

		public ShoppingCart GetShoppingCartByCustomerIdAndProductId(int customerId, int productId)
		{
			var shoppingCart = _context
				.ShoppingCarts
				.FirstOrDefault(x => x.CustomerId == customerId && x.ProductId == productId);

			return shoppingCart;
		}


		public void Add(ShoppingCart shoppingCart)
		{
			_context.ShoppingCarts.Add(shoppingCart);
			_context.SaveChanges();
		}

		public void DeleteShoppingCartById(int shoppingCartId)
		{
			ShoppingCart shoppingCart = GetShoppingCartById(shoppingCartId);
			_context.ShoppingCarts.Remove(shoppingCart);
			_context.SaveChanges();
		}

		public void UpdateShoppingCartByShoppingCart(ShoppingCart shoppingCart)
		{
			ShoppingCart currentShoppingCart = GetShoppingCartByCustomerIdAndProductId(shoppingCart.CustomerId, shoppingCart.ProductId);

			if (currentShoppingCart != null)
			{
				currentShoppingCart.QuantityToBuy += shoppingCart.QuantityToBuy;
			}
			else
			{
				Add(shoppingCart);
			}

			_context.SaveChanges();		
		}
	}
}

namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCartService
    {
        private SuperMContext Context;

        public ShoppingCartService()
        {
            Context = new SuperMContext();
        }

        public List<ShoppingCart> GetShoppingCartList()
        {
            var shoppingCarts = Context.ShoppingCarts.ToList();
            return shoppingCarts;
        }

        public ShoppingCart GetShoppingCartById(int shoppingCartId)
        {
            ShoppingCart shoppingCart = Context.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartId == shoppingCartId);
            return shoppingCart;
        }

        public List<ShoppingCart> GetShoppingCartByCustomerId(int customerId)
        {
            List<ShoppingCart> shoppingCarts = Context.ShoppingCarts.Where(x => x.CustomerId == customerId).ToList();
            return shoppingCarts;
        }

        public ShoppingCart GetShoppingCartByCustomerIdAndProductId(int customerId, int productId)
        {
            var shoppingCart = Context
                .ShoppingCarts
                .FirstOrDefault(x => x.CustomerId == customerId && x.ProductId == productId);

            return shoppingCart;
        }

        public void Add(ShoppingCart shoppingCart)
        {
            Context.ShoppingCarts.Add(shoppingCart);
            Context.SaveChanges();
        }

        public void DeleteShoppingCartById(int shoppingCartId)
        {
            ShoppingCart shoppingCart = GetShoppingCartById(shoppingCartId);
            Context.ShoppingCarts.Remove(shoppingCart);
            Context.SaveChanges();
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

            Context.SaveChanges();
        }
    }
}

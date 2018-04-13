using SuperM.Business.Services;
using SuperM.Data.Entities;
using SuperM.UI.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperM.UI.WebApp.Controllers
{
    public class CartController : Controller
    {
		public ShoppingCartService ShoppingCartService { get; set; }
		public ProductService ProductService { get; set; }

        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult AddToCart(Product product)
		{
			ViewBag.ProductName = product.Name;
			string productName = ProductService.GetProductById(product.ProductId).Name;
			ShoppingCart shoppingCart = new ShoppingCart()
			{
				CustomerId = 1,
				ProductId = product.ProductId
			};
			return View(shoppingCart);
		}

		// GET: Cart/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
			return View();
        }

        // POST: Cart/Create
        [HttpPost]
        public ActionResult UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            try
            {
				ShoppingCartService.UpdateShoppingCartByShoppingCart(shoppingCart);

				return RedirectToAction("CartList", shoppingCart);
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

		public ActionResult CartList(ShoppingCart shoppingCart)
		{
			List<ShoppingCart> list = ShoppingCartService.GetShoppingCartByCustomerId(shoppingCart.CustomerId);
			return View(list);
		}
    }
}

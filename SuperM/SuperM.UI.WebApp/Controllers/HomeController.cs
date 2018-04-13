using SuperM.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperM.UI.WebApp.Controllers
{
	public class HomeController : Controller
	{
		public ProductService _productService { get; set; } = new ProductService();

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";
			var products = _productService.GetProductList();
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
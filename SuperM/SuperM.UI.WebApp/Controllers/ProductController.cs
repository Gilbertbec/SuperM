using SuperM.Business.Services;
using SuperM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperM.UI.WebApp.Controllers
{

    public class ProductDetailController : Controller
    {
		public ProductService productService { get; set; }
		
		// GET: Product
		public ActionResult Index(int productId)
        {
			Product product = productService.GetProductById(productId);
			return View(product);
        }
    }
}
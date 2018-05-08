namespace SuperM.UI.WebApp.Controllers
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System.Web.Mvc;

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

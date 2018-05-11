namespace SuperM.UI.WebApp.Controllers
{
    using SuperM.Business.Services;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ProductService ProductService { get; set; } = new ProductService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var products = ProductService.GetProductList();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

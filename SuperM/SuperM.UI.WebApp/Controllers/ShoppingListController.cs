namespace SuperM.UI.WebApp.Controllers
{
    using SuperM.Business.Services;
    using System.Linq;
    using System.Web.Mvc;

    public class ShoppingListController : Controller
    {
        public InventoryService inventoryService { get; set; }

        // GET: ShoppingList
        public ActionResult Index()
        {
            var inventoryList = inventoryService.GetInventoryList().ToArray();
            return View(inventoryList);
        }
    }
}

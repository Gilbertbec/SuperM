using SuperM.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperM.UI.WebApp.Controllers
{
    public class ShoppingListController : Controller
    {
		public InventoryService inventoryService { get; set; }

		// GET: ShoppingList
		public ActionResult Index()
        {
			var inventoryList = inventoryService.GetInventoryList().ToArray();
            return View(inventoryList);
        }

        public ActionResult MvcPager(int id = 1)
        {
            var inventoryList = inventoryService.GetInventoryList().ToArray();
            int counts = inventoryList.Count();
            //PageList<inventory> lst = inventoryList.AsQueryable().ToPagedList(id, PageSize);
            //lst.TotalItemCount = counts;
            //lst.CurrentPageIndex = id;
            //return View(lst);
        }
    }
}
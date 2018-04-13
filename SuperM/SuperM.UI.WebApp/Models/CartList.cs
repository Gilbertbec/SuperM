using SuperM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperM.Business.Services;

namespace SuperM.UI.WebApp.Models
{
	public class CartList
	{
		public int CartListId { get; set; }
		public int CustomId { get; }
		public ShoppingCart ShoppingCart {get; set;}
	}
}
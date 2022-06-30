using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchApplication.Models;

namespace SearchApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public JsonResult Getemp(string Recipe_name)
		{
			Search_dbEntities sdb = new Search_dbEntities();
			var recipe = (from x in sdb.Recipes where x.Recipe_name.StartsWith(Recipe_name) select new { label = x.Recipe_name }).ToList();
			return Json(recipe);
		}

		
	}
}
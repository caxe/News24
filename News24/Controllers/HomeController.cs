using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using News24.JSON_Methods;
using News24.Models;
using Newtonsoft.Json;

namespace News24.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.listSource = LoadSources.LoadSourceList();
			return View();
		}

		[HttpPost]
		public ActionResult GetSource(string source)
		{
			var articles = LoadArticles.LoadSourceArticlesList(source);
			ViewBag.listArticles = articles;
			return ViewBag.listArticles;
		}

		public ActionResult About()
		{
			ViewBag.Message = "Website about news.";

			return View();
		}
	}
}

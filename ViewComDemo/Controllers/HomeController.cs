using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewComDemo.Models;

namespace ViewComDemo.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace BlogSitesi.UI.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

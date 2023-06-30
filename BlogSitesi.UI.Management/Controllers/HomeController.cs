using Microsoft.AspNetCore.Mvc;

namespace BlogSitesi.UI.Management.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

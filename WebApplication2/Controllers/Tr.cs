using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class Tr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult TinyHouse()
		{
			return View();
		}
		public IActionResult TinyHouseDetay()
		{
			return View();
		}
	}
}

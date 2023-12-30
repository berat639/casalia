using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class En : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult TinyHouse()
		{
			return View();
		}
		public IActionResult TinyHouseDetail()
		{
			return View();
		}
	}
} 

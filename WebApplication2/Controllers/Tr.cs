using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class Tr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult TinyHouseDetay()
		{
			return View();
		}
		[Route("tr/otomatik-paketleme-rulolari")]
		public IActionResult OtomatikPaketlemeRulolari()
		{
			return View();
		}

		// MİKRO DELİKLİ AMBALAJ
		[Route("tr/mikro-delikli-ambalaj")]
		public IActionResult MikroDelikliAmbalaj()
		{
			return View();
		}

		// SEBZE - MEYVE TORBALARI
		[Route("tr/sebze-meyve-torbalari")]
		public IActionResult SebzeMeyveTorbalari()
		{
			return View();
		}

		// ÇİÇEK TORBALARI
		[Route("tr/cicek-torbalari")]
		public IActionResult CicekTorbalari()
		{
			return View();
		}

		// KAĞIT ÇİÇEK TORBALARI
		[Route("tr/kagit-cicek-torbalari")]
		public IActionResult KagitCicekTorbalari()
		{
			return View();
		}

		// EKMEK TORBALARI
		[Route("tr/ekmek-torbalari")]
		public IActionResult EkmekTorbalari()
		{
			return View();
		}

		// KASA FÖYLERİ
		[Route("tr/kasa-foyleri")]
		public IActionResult KasaFoyleri()
		{
			return View();
		}

		// KARGO TORBALARI
		[Route("tr/kargo-torbalari")]
		public IActionResult KargoTorbalari()
		{
			return View();
		}

		// PETEK KORUYUCULU KARGO TORBALARI
		[Route("tr/petek-koruyuculu-kargo-torbalari")]
		public IActionResult PetekKoruyuculuKargoTorbalari()
		{
			return View();
		}

		// TEKSTİL TORBALARI
		[Route("tr/tekstil-torbalari")]
		public IActionResult TekstilTorbalari()
		{
			return View();
		}

		// ÇÖP TORBALARI
		[Route("tr/cop-torbalari")]
		public IActionResult CopTorbalari()
		{
			return View();
		}

		// GÜVENLİK TORBALAR
		[Route("tr/guvenlik-torbalari")]
		public IActionResult GuvenlikTorbalari()
		{
			return View();
		}

		// PE SHRINK FILM
		[Route("tr/pe-shrink-film")]
		public IActionResult PeShrinkFilm()
		{
			return View();
		}

	}
}

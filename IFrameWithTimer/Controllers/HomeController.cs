using IFrameWithTimer.Models;
using Microsoft.AspNetCore.Mvc;

namespace IFrameWithTimer.Controllers
{
	public class HomeController : Controller
	{
		public TimerLinks timerLinks = new TimerLinks()
		{
			Id = 1,
			Duration = 10,
			Urls = new List<string>()
			{

                "https://www.youtube.com/embed/2ll4IA146YI",
                "https://www.youtube.com",
                "https://www.yahoo.com",
                "https://www.gmail.com"
            }
		};
		public IActionResult Index()
		{
			return View(timerLinks);
		}
		[HttpPost]
		public IActionResult AddLink(string link)
		{
			timerLinks.Urls.Add(link);
			return View("Index",timerLinks);
		}

		public IActionResult DeleteLink(string link)
		{
			timerLinks.Urls.Remove(link);
			return View("Index",timerLinks);
		}


		public IActionResult SetTimer(int duration)
		{
			timerLinks.Duration = duration;
			return View("Index",timerLinks);
		}


	}
}

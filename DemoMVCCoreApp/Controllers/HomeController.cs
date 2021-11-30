using DemoMVCCoreApp.Models;
using DemoMVCCoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVCCoreApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IDateService _dateService;
		public HomeController(ILogger<HomeController> logger, IDateService dateService)
		{
			_logger = logger;
			_dateService = dateService;
		}

		public IActionResult Index()
		{
			var today = _dateService.Today;
			if(today.Month == 3 && today.Day == 21)
			{
				ViewData["message"] = "Spring has started, enjoy our spring sale.";
			}
			else
			{
				ViewData["message"] = "Spring has not started, There will be our spring sale.";
			}
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

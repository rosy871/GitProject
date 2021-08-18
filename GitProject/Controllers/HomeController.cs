using GitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Index2()   // added
		{
			return View();
		}
		public IActionResult Index3()   // added
		{
            int i = "2";
			int i1 = 0;
			return View();
		}

		public IActionResult Privacy()
        {
            return View();
        }
        //Added privacy
        public IActionResult Privacy2()
        {
            return View();
        }

        // Added About (Per Gref)
        public IActionResult About()
        {
            // This is an added comment by Per Gref
            return View();
            var txt = "rosy";
            return View();
			int i1 = 0;
			int i2 = 0;
			return View();
        }

        // Added About2 (Per Gref)
        public IActionResult About2()
        {
			int i1 = 0;
			int i2 = 0;
			return View();
            var txt = "this is test";
            return View();
        }

        // Added About3 (Per Gref)
        public IActionResult About3()
        {
			int i1 = 0;
			int i2 = 0;
			return View();
        }

        // Added About4 in Local Personal Branch (Per Gref) 
        public IActionResult About4()
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

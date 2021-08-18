﻿using GitProject.Models;
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
            var txt = "rosy";
            return View();
        }

        // Added About2 (Per Gref)
        public IActionResult About2()
        {
            var txt = "this is test";
            return View();
        }

        // Added About3 (Per Gref)
        public IActionResult About3()
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

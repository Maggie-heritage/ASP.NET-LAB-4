﻿using lab3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Controllers
{
    public class Account : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Account(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public ActionResult Index()
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

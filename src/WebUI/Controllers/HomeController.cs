﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codidact.WebUI.Models;
using Services;

namespace Codidact.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommunityService _communityService;

        public HomeController(ILogger<HomeController> logger, ICommunityService communityService)
        {
            _logger = logger;
            _communityService = communityService;
        }

        public IActionResult Index()
        {
            _communityService.GetID();
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

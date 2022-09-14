using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameSiteMvc.Models;

namespace GameSiteMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyFirstPageViewModel _myFirstPage;

        public HomeController(ILogger<HomeController> logger, MyFirstPageViewModel myFirstPage)
        {
            _logger = logger;
            _myFirstPage = myFirstPage;
        }

        public IActionResult MyFirstPage()
        {
            return View(_myFirstPage);
        }

        public IActionResult Index()
        {
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

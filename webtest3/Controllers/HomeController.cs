using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webtest3.Models;

namespace webtest3.Controllers
{
    [Authorize(Roles ="Admin")]
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

        [Authorize(Roles ="SuperAdmin")]
        public IActionResult Privacy()
        {
            //return View();
            return ViewComponent("MessagePage", new webtest3.Views.Shared.Components.MessagePage.MessagePage.Message
            {
                title = "Thông báo quan trọng -  test component",
                htmlcontent = "<strong>Ban la superadmin - co quyen truy cap</strong>",
                secondwait = 5,
                urlredirect = "/Home/Index"
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

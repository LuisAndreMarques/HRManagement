using Epifania.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Epifania.Controllers
{
    public class BackOfficeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BackOfficeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult BackOfficeMain()
        {
            return View("~/Views/Shared/_LayoutBackend/Main.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
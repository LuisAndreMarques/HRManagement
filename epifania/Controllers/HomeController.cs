using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using epifania.Models;
using epifaniaData.Logic;

namespace epifania.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult User()
        {
            return View();
        } 
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult User(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
             int re=   UsersProc.CreateUser(userModel.Username, userModel.Password, userModel.FirstName, userModel.LastName, userModel.Email,
                    userModel.Telephone, userModel.Address1, userModel.Address2, userModel.NIF);
                
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}

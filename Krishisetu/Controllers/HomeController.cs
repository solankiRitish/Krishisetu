using System.Diagnostics;
using Krishisetu.Models;
using Microsoft.AspNetCore.Mvc;

namespace Krishisetu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        ublic IActionResult Profile()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Weather()
        {
            return View();
        }

        public IActionResult Farmer()
        {
            return View();
        }

        public IActionResult Driver()
        {
            return View();
        }

        public IActionResult Seller()
        {
            return View();
        }

        public IActionResult Buyer()
        {
            return View();
        }

        public IActionResult Famer_Posts()
        {
            return View();
        }

        public IActionResult Driver_posts()
        {
            return View();
        }

        public IActionResult Seller_posts()
        {
            return View();
        }

        public IActionResult Buyer_posts()
        {
            return View();
        }

        public IActionResult Logout()
        {

            return View("LogoutLoading");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

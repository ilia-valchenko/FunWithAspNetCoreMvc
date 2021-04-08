using System.Diagnostics;
using FunWithAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunWithAspNetCoreMvc.Controllers
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
            // We have an overloaded version of View method which allow us
            // to specify which view we want to return.
            // public virtual ViewResult View(string viewName)

            return View();
        }

        public IActionResult Privacy()
        {
            // We have an overloaded version of View method which allow us
            // to specify which view we want to return.
            // public virtual ViewResult View(string viewName)

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
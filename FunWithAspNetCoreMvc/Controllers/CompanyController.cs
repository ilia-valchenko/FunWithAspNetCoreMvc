using System.Collections.Generic;
using FunWithAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FunWithAspNetCoreMvc.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            var model = new CompanyPlainModel
            {
                CompanyName = "Microsoft",
                NumberOfEmployees = 1000,
                AverageSalaryAmount = 5000
            };

            // Internally ViewBag properties are stored as name/value pairs in the ViewData dictionary.
            // ViewData["Foo"] ---> It requires type casting for complex data types and checks for null values to avoid errors.
            // ViewBag.Foo ---> It doesn’t require type casting for complex data types.
            // The most notable difference is ViewData is a strongly typed dictionary while ViewBag is a dynamic type.
            ViewData["totalSalary"] = model.NumberOfEmployees * model.AverageSalaryAmount;
            ViewData["company"] = model.CompanyName;
            ViewData["employees"] = model.NumberOfEmployees;

            ViewBag.TestNumber = 111;

            return View();
        }

        // The attribute below allows us to override the name of an action.
        [ActionName("GetAllCompanies")]
        public IActionResult GetAll()
        {
            var models = new List<CompanyPlainModel>()
            {
                new CompanyPlainModel { CompanyName = "Microsoft", NumberOfEmployees = 1000, AverageSalaryAmount = 5000 },
                new CompanyPlainModel { CompanyName = "Intel", NumberOfEmployees = 5000, AverageSalaryAmount = 15000 },
                new CompanyPlainModel { CompanyName = "Google", NumberOfEmployees = 12000, AverageSalaryAmount = 30000 }
            };

            return View(models);
        }
    }
}
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

            ViewData["totalSalary"] = model.NumberOfEmployees * model.AverageSalaryAmount;
            ViewData["company"] = model.CompanyName;
            ViewData["employees"] = model.NumberOfEmployees;

            return View();
        }

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
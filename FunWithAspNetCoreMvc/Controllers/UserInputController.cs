using System;
using System.Text;
using FunWithAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FunWithAspNetCoreMvc.Controllers
{
    // It's a bad controller name. Don't use it :)
    public class UserInputController : Controller
    {
        public IActionResult Index()
        {
            // The view contains a set of user inputs.
            return View();
        }

        // EXAMPLE #1: The action parameters names should match HTML input names.
        public string ProceedResult1(string firstname, string lastname, int age)
        {
            var user = new User
            {
                FirstName = firstname,
                LastName = lastname,
                Age = age
            };

            return $"EXAMPLE #1. Firstname: {user.FirstName}, Lastname: {user.LastName}, Age: {user.Age}.";
        }

        // EXAMPLE #2: The properties names should match HTML input names.
        public string ProceedResult2(User user)
        {
            return $"EXAMPLE #2. Firstname: {user.FirstName}, Lastname: {user.LastName}, Age: {user.Age}.";
        }

        // EXAMPLE #3
        public string ProceedResult3(User[] users)
        {
            var strBuilder = new StringBuilder("EXAMPLE #3" + Environment.NewLine);

            foreach (var user in users)
            {
                strBuilder.AppendLine($"Firstname: {user.FirstName}, Lastname: {user.LastName}, Age: {user.Age}.");
            }

            return strBuilder.ToString();
        }
    }
}
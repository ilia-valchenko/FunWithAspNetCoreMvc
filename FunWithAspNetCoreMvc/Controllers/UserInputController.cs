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
        public string ProceedResult(string firstname, string lastname, int age)
        {
            var user = new User
            {
                FirstName = firstname,
                LastName = lastname,
                Age = age
            };

            return $"Firstname: {user.FirstName}, Lastname: {user.LastName}, Age: {user.Age}.";
        }
    }
}
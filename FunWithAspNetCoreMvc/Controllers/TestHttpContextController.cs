using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace FunWithAspNetCoreMvc.Controllers
{
    public class TestHttpContextController : Controller
    {
        public string Index()
        {
            var elements = Request.Headers;
            var result = new StringBuilder();

            foreach (var item in elements)
            {
                result.AppendLine($"{item.Key} = {item.Value}");
            }

            return result.ToString();
        }
    }
}
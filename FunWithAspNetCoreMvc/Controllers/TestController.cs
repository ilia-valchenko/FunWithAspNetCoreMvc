using Microsoft.AspNetCore.Mvc;

namespace FunWithAspNetCoreMvc.Controllers
{
    // Note: The class was marked by the [NonController] attribute.
    [NonController]
    public class TestController
    {
        private const int Good = 0;
        private const int Bad = 1;

        public int GetStatusCode()
        {
            return Good;
        }
    }
}
using FunWithAspNetCoreMvc.Service.Interfaces;

namespace FunWithAspNetCoreMvc.Service
{
    public class GreetingServicecs : IGreetingServicecs
    {
        public string GetGreetingText()
        {
            return "Welcome to our web site!";
        }
    }
}
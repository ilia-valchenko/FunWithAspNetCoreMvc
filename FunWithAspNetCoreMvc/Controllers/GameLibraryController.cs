using FunWithAspNetCoreMvc.Enums;
using FunWithAspNetCoreMvc.Models;
using FunWithAspNetCoreMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunWithAspNetCoreMvc.Controllers
{
    public class GameLibraryController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new GameLibraryViewModel
            {
                Username = "Ilya Valchanka",
                PcGames = new[]
                {
                    new PcGame
                    {
                        Name = "The Witcher 3",
                        Platform = PcPlatform.Windows
                    },
                    new PcGame
                    {
                        Name = "Mass Effect 2",
                        Platform = PcPlatform.Windows
                    }
                },
                ConsoleGames = new[] {
                    new ConsoleGame
                    {
                        Name = "God of War",
                        Console = Console.PlayStation
                    },
                    new ConsoleGame
                    {
                        Name = "Sea of Thieves",
                        Console = Console.Xbox
                    }
                }
            };

            return View(viewModel);
        }
    }
}
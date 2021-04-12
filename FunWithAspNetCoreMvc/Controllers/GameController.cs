using System.Collections.Generic;
using FunWithAspNetCoreMvc.Enums;
using FunWithAspNetCoreMvc.Models;
using FunWithAspNetCoreMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunWithAspNetCoreMvc.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new GameLibraryViewModel
            {
                PcGames = new List<PcGame>
                {
                    new PcGame
                    {
                        Name = "Fallout",
                        Platform = Platform.Windows
                    },
                    new PcGame
                    {
                        Name = "Hitman",
                        Platform = Platform.Windows
                    }
                },
                ConsoleGames = new List<ConsoleGame>
                {
                    new ConsoleGame
                    {
                        Name = "Uncharted",
                        Type = ConsoleType.PlayStation,
                    },
                    new ConsoleGame
                    {
                        Name = "God of War",
                        Type = ConsoleType.PlayStation
                    }
                }
            };

            return View(viewModel);
        }
    }
}
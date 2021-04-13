using System.Collections.Generic;
using FunWithAspNetCoreMvc.Models;

namespace FunWithAspNetCoreMvc.ViewModels
{
    public class GameLibraryViewModel
    {
        public string Username { get; set; }

        public IEnumerable<PcGame> PcGames { get; set; }

        public IEnumerable<ConsoleGame> ConsoleGames { get; set; }
    }
}
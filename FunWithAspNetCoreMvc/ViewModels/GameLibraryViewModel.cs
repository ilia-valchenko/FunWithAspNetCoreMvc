using System.Collections.Generic;
using FunWithAspNetCoreMvc.Models;

namespace FunWithAspNetCoreMvc.ViewModels
{
    // We have to use the view model below because we cannot pass two different collections
    // to a view by using @model List<T>.
    public class GameLibraryViewModel
    {
        public string Username { get; set; }

        public IEnumerable<PcGame> PcGames { get; set; }

        public IEnumerable<ConsoleGame> ConsoleGames { get; set; }
    }
}
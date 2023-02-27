using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added: " + game.GameName + " Game Description" + game.GameDescription);
        }

        public void Delete(Game game)
        { 
            Console.WriteLine("Game deleted: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated: " + game.GameName + " Game Description" + game.GameDescription);
        }
    }
}

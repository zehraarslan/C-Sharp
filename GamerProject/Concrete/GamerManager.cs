using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    internal class GamerManager : IGamerService
    {
        IGamerCheckService _checkService;

        public GamerManager(IGamerCheckService checkService)
        {
            _checkService = checkService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Gamer added: " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                throw new Exception("Kişi değil.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}

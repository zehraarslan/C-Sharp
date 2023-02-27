using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("******** Oyun Satışı ********");
            Console.WriteLine("İsim-Soyisim:" + " " + gamer.FirstName + " " + gamer.LastName);
            Console.WriteLine("Oyun:" + game.GameName + " , Kampanya Türü: " + " " + campaign.CampaignName);
            Console.WriteLine("************************");
        }
    }
}

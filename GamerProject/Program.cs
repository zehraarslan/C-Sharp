using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entities;

namespace GamerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "Zehra",
                LastName = "ARSLAN",
                DateOfBirth = new DateTime(1994),
                NationalityId = "146546"
            };
            IGamerService gamerService = new GamerManager(new GamerCheckManager());
            gamerService.Add(gamer);

            Game game = new Game()
            {
                Id = 2,
                GameName = "Savaş Alanı2",
                GamePrice = 150,
                GameDescription = "Strateji oyunu."
            };
            IGameService gameService = new GameManager();
            gameService.Add(game);


            Campaign campaign = new Campaign()
            {
                Id = 3,
                CampaignName = "23 Yaz Kampnyası",
                CampaignDescription = "Savaş oyunlarında %25 indirim..."
            };
            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign);

            ISalesService salesService = new SalesManager();
            salesService.Add(gamer, game, campaign);
        }
    }
}
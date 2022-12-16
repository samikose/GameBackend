using DemoGame.Adapter;
using DemoGame.Concrete;
using DemoGame.Entities;
using System;

namespace DemoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.FirstName = "Sami";
            player1.LastName = "Köse";
            player1.DateOfBirth = new DateTime(2002, 5, 8);
            player1.NationalId = 37018039180;
            player1.Id = 1;

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Register(player1);

            Products product1 = new Products();
            product1.Id = 1;
            product1.Name = "Mafia 2";
            product1.Price = 39.99;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Campaigns campaign1 = new Campaigns();
            campaign1.Id = 1;
            campaign1.Name = "Black Friday";
            campaign1.DiscountRate = 40;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.ApplyThisCampaign(campaign1,product1);

            SalesManager salesManager = new SalesManager();
            salesManager.Info(player1,product1);

        }
    }
}

using System;
using GameStore.Abstract;
using GameStore.Entities;
using GameStore.Concrete;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Müşterileri yönetmek için ENTER'a tıklayınız.");
            Console.ReadLine();

            CustomerManager customerManager = new CustomerManager(new CheckManager());
            Customer customer1 = new Customer { CustomerId = 1, FirstName = "Ali", LastName = "İnce", DateOfBirth = new DateTime(1997, 1, 1), TCNo = "33243232423" };
            Customer customer2 = new Customer { CustomerId = 2, FirstName = "Veli", LastName = "İnce", DateOfBirth = new DateTime(1997, 1, 1), TCNo = "33243232423" };
            Customer customer3 = new Customer { CustomerId = 3, FirstName="Mahmut", LastName = "İnce" };
            customerManager.Add(new Customer{ CustomerId = 4,FirstName = "Mahmut",LastName = "İnce",DateOfBirth = new DateTime(1997, 1, 1),TCNo = "33243232423"});
            customerManager.Delete(customer1);
            customerManager.Update(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("\nOyunları yönetmek için ENTER'a tıklayınız.");
            Console.ReadLine();
            GameManager gameManager = new GameManager();
            Game game1 = new Game { GameId = 1, GameName = "Stronghold Crusader", GamePrice = 19 };
            Game game2 = new Game { GameId = 2, GameName = "Europa Universalis IV", GamePrice = 39 };
            Game game3 = new Game { GameId = 3, GameName = "victoria II", GamePrice = 29 };
            gameManager.Add(game1);
            gameManager.Delete(game2);

            Console.WriteLine("\nKampanyaları yönetmek için ENTER'a tıklayınız.");
            Console.ReadLine();

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { CampaignId = 1, CampaignName = "Bahar İndirimleri", DiscountRate = 0.4 };
            Campaign campaign2 = new Campaign { CampaignId = 2, CampaignName = "Kış İndirimleri", DiscountRate = 0.5 };
            Campaign campaign3 = new Campaign { CampaignId = 3, CampaignName = "Güz İndirimleri", DiscountRate = 0.2 };
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            Console.WriteLine("\nSatışları yönetmek için ENTER'a tıklayınız.");
            Console.ReadLine();

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(customer1, game1);
            salesManager.SellWithCampaign(customer2, game1,campaign2);








        }
    }
}

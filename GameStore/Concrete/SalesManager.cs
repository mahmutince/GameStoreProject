using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sell(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName+" adlı kullanıcı "+ game.GameName + " adlı oyunu satın aldı. Ürün Fiyatı: " + game.GamePrice);
        }

        public void SellWithCampaign(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı " + game.GameName + " adlı oyunu satın aldı. Ürünün kampanyalı fiyatı: " + game.GamePrice*campaign.DiscountRate);
        }
    }
}

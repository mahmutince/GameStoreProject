using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Entities;

namespace GameStore.Abstract
{
    interface ISalesService
    {
        void Sell(Customer customer, Game game);
        void SellWithCampaign(Customer customer, Game game, Campaign campaign);
    }
}

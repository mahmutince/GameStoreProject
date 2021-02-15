using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" adlı kampanya başlatıldı.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya kaldırıldı.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya güncellendi.");
        }
    }
}

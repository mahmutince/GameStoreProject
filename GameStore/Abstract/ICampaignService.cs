using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Entities;

namespace GameStore.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}

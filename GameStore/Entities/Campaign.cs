﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
    }
}

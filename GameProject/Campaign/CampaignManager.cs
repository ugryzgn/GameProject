using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Added campaign: " + campaign.Name + "  Expiry Date: " + campaign.AdFlight);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted campaign: " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated campaign: " + campaign.Name + "  Expiry Date: " + campaign.AdFlight);
        }
    }
}

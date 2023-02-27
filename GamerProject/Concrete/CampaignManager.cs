using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added : " + campaign.CampaignName + "   Campaign detail :" + campaign.CampaignDescription);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated : " + campaign.CampaignName + "   Campaign detail :" + campaign.CampaignDescription);
        }
    }
}

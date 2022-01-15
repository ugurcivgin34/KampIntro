using _5.Gun_Odev_GameBackend.Abstract;
using _5.Gun_Odev_GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Concrete
{

    public class CampaignManager : ICampaignService
    {




        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi " + campaign.CampaignName);
        }


    }
}

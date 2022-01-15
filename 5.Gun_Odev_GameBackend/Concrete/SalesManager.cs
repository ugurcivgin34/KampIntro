using _5.Gun_Odev_GameBackend.Abstract;
using _5.Gun_Odev_GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Concrete
{
    public class SalesManager : ISalesService
    {
         
        public void Sales(Gamer gamer, Game game , Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu " + game.GameName + " adlı oyunu " +campaign.CampaignName+ " kampyansından yararlanarak " + game.Price +" tl ye aldı");
            
        }
    }
}

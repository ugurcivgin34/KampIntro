using _5.Gun_Odev_GameBackend.Adapters;
using _5.Gun_Odev_GameBackend.Concrete;
using _5.Gun_Odev_GameBackend.Entities;
using System;

namespace _5.Gun_Odev_GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "uğur okan", LastName = "çivgin", NationalityId = 12345678910, BirthYear = 1994 };
            Gamer gamer2 = new Gamer { Id = 2, FirstName = "sait", LastName = "çivgin", NationalityId = 1234698574, BirthYear = 1994 };
            Gamer gamer3 = new Gamer { Id = 3, FirstName = "enes", LastName = "çetindaş", NationalityId = 52145854569, BirthYear = 1994 };

            //---------------------------------------------------------------------

            Game game1 = new Game { Id = 1, GameName = "Last of us", Price = 3600 };
            Game game2 = new Game { Id = 2, GameName = "Days gone", Price = 4503 };
            Game game3 = new Game { Id = 3, GameName = "Call of duty", Price = 3504 };

            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Öğrenci" };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Öğretmen" };



            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();

       
            salesManager.Sales(gamer1, game1, campaign1);




        }
    }
}

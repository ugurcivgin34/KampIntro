using _5.Gun_Odev_GameBackend.Abstract;
using _5.Gun_Odev_GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Concrete
{



    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }


        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerService(gamer))
                Console.WriteLine("Oyuncu Eklendi " + gamer.FirstName);
            else
                Console.WriteLine("Türkiye Devletinde böyle bir tc bulunmamaktadır.Lütfen kontrol ediniz.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Sildindi " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi" + gamer.FirstName);
        }
    }
}

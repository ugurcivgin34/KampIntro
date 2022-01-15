using _5.Gun_Odev_GameBackend.Abstract;
using _5.Gun_Odev_GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi " + game.GameName);
        }
    }
}

using _5.Gun_Odev_GameBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public double Price { get; set; }
       
        public string GameName { get; set; }
    }
}

using _5.Gun_Odev_GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Abstract
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}

using _5.Gun_Odev_GameBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Gun_Odev_GameBackend.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
       
    }
}

using _5.Gun_Odev_GameBackend.Abstract;
using _5.Gun_Odev_GameBackend.Entities;
using MerniseServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MerniseServiceReference.KPSPublicSoapClient;

namespace _5.Gun_Odev_GameBackend.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerService(Gamer gamer)
        {
            var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                ((gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.BirthYear).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        }
    }
}

using DemoGame.Abstract;
using DemoGame.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGame.Adapter
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(player.NationalId, player.FirstName, player.LastName, player.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

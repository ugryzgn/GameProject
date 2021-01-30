using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.NationalID,
                gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

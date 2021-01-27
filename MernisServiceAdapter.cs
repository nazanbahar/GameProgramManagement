using MernisServiceReference;
using System;
using GameProgramManagementDemo.Abstract;
/// <summary>
/// //old version check code
//KPSPublicSoapClient client = new KPSPublicSoapClient();
//return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), 
// customer.FirstName.ToUpper(),customer.LastName.ToUpper(), customer.DateOfBirth.Year);
/// </summary>
namespace GameProgramManagementDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService

    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //real system

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
          

        }

    }
}

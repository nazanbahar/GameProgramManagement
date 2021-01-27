using GameProgramManagementDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// //return - kendi servisimiz - test ortamında kullanılabilir.
///  //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();  -- bagimli bir sistem bu satır
/// </summary>
namespace GameProgramManagementDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            
            return true;
           
        }
    }
}

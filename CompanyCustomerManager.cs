using GameProgramManagementDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
///         mernis doğrulaması isterse...
        //public override void Save(Customer customer)
        //{
        //    //Mernis Doğrulaması
        //    if (_customerCheckService.CheckIfRealPerson(customer))
        //    {
        //        base.Save(customer);
        //    }
        //    else
        //    {
        //        throw new Exception("Not a valid person");
        //    }
        //}
/// </summary>
namespace GameProgramManagementDemo.Concrete
{
    public class CompanyCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CompanyCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


    }
}


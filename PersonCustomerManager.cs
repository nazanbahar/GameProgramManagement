using GameProgramManagementDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Concrete
{

    //direkt referans oluşturduk.
    public class PersonCustomerManager : BaseCustomerManager          //,ICustomerCheckService
    {

        private ICustomerCheckService _customerCheckService;

        public PersonCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }



        //overrride-virtual
        public override void Save(Customer customer)
        {
            //Mernis Doğrulaması
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
                Console.WriteLine("NationalityId Doğrulandı...");
            }
            else
            {
                Console.WriteLine("NationalityId Geçersiz...");
            }

        }

    }
}

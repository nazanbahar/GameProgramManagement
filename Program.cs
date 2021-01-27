using GameProgramManagementDemo.Abstract;
using GameProgramManagementDemo.Adapters;
using GameProgramManagementDemo.Concrete;
using System;

namespace GameProgramManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //mernis sadece doğum yılını kontrol ediyor.
            BaseCustomerManager customerManager = new PersonCustomerManager(new MernisServiceAdapter());


            customerManager.Save(new Customer
            {
                NationalityId = 65903045602,
                FirstName = "Can",
                LastName = "Bahar",
                DateOfBirthYear = 1974
            });

        }
    }
}

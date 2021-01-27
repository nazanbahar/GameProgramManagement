using System;
using System.Collections.Generic;
using System.Text;


namespace GameProgramManagementDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        //Abstract sınıf icinde ici dolu metot yapılabiliyor. Ortak operasyon
        //virtual ezilebilir.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db   : " + customer.FirstName);
        }
    }
}

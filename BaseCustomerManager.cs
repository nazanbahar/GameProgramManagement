using System;
using System.Collections.Generic;
using System.Text;


namespace GameProgramManagementDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void CustomerMadePreferred(Customer customer)
        {
            throw new NotImplementedException();
        }

        //Abstract sınıf icinde ici dolu metot yapılabiliyor. Ortak operasyon
        //virtual ezilebilir.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db   : " + customer.FirstName);
        }
    }
}

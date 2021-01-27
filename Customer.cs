using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgramManagementDemo.Abstract
{
    public class Customer : IEntity
    {
        //NationalityId, DateOfBirthYear, FirstName, LastName, Contact ,Mail

        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
         public string Contact { get; set; }
        public string Mail { get; set; }


  

    }
}

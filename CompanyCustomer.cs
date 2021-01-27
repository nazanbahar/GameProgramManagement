using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// //CompanyName, TaxNumber, WebSite
/// </summary>
namespace GameProgramManagementDemo.Abstract
{
    public class CompanyCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string WebSite { get; set; }

    }
}

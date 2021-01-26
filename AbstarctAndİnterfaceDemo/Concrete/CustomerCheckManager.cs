using AbstarctAndİnterfaceDemo.Abstract;
using AbstarctAndİnterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace AbstarctAndİnterfaceDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
     
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

       
    }
}

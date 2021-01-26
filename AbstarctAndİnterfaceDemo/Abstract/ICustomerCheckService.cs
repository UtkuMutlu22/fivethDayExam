using AbstarctAndİnterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctAndİnterfaceDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

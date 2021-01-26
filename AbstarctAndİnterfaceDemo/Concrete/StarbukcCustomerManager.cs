using AbstarctAndİnterfaceDemo.Abstract;
using AbstarctAndİnterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctAndİnterfaceDemo.Concrete
{
    public class StarbukcCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public StarbukcCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        
    }    


    
}

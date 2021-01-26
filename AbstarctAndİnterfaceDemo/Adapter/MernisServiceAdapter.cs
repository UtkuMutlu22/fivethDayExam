using AbstarctAndİnterfaceDemo.Abstract;
using AbstarctAndİnterfaceDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctAndİnterfaceDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync((Convert.ToInt64(customer.NationaltyId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year));
        }
    }
}

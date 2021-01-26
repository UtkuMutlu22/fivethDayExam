using AbstarctAndİnterfaceDemo.Abstract;
using AbstarctAndİnterfaceDemo.Adapter;
using AbstarctAndİnterfaceDemo.Concrete;
using AbstarctAndİnterfaceDemo.Entities;
using System;

namespace AbstarctAndİnterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbukcCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 1, 10),
                FirstName = "Utku",
                LastName = "Mutlu",
                NationaltyId = "31459441472"
            });
            Console.ReadKey();
        }
    }
}

using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Update();
            productManager.Add();

            Customer customer = new Customer();
            customer.City = "Edirne";
            customer.Id = 1;
            customer.FirstName = "Utku";
            customer.LastName = "Mutlu";

            Customer customer1 =new Customer
            {
                Id=2,City="Edirne",FirstName="Arzu",LastName="Mutlu"
            
            };

            Console.WriteLine(customer1.FirstName);
        }
    }
}

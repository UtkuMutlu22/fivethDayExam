using System;

namespace İnterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesesIntro();

            //Interfaceses1();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {new SqlServerCustomerDal(),new OracelCustomerDal(),new MySqlCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Interfaceses1()
        {
            IPerson person = new Customer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracelCustomerDal());
        }

        private static void InterfacesesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Utku", LastName = "Mutlu", Address = "Edirne" });

            Student student = new Student { Id = 1, FirstName = "Arzu", LastName = "Mutlu", Departmant = "Math" };

            personManager.Add(student);
        }

        interface IPerson
        {
             int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set ; }
            public string LastName { get; set ; }


            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get ; set ; }


            public string Departmant { get; set; }
        }
        class PersonManager
        {
           public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}

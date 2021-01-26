using System;

namespace Interfaceses2
{
    class Program
    {
        static void Main(string[] args)
        {;
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            IPersonManager internManager = new InternManager();
            projectManager.Add(internManager);
           
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Musteri Ekleme Kodları

            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncelleme");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer Güncellendi");
        }
    }


    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Calisan ekleme kodlari
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Guncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        

    }
}

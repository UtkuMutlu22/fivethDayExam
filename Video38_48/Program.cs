using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Amevzuat amevzuat = new Amevzuat();
            amevzuat.Kaydet();
            amevzuat.Degerlendir();
        }
    }

    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }
        public abstract void Degerlendir();
        
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
    class Amevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatına Göre değerlendir");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }
    class CustomerManager
    {
        public void Add()
        {

        }
        public void Delete()
        {

        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

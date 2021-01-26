using System;

namespace İnterfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new BirinciMevzuat());
            customerManager.Add();
        }
    }
    class CustomerManager
    {
        private IMevzuat _mevzuat;

        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }

        public void Add()
        {
            _mevzuat.IslemYap();
            
        }
    }
    interface IMevzuat
    {
        void IslemYap();
    }
    class BirinciMevzuat : IMevzuat //Birinci mevzuat,Imevzuat implementasyonudur.
    {
        public void IslemYap()
        {
            Console.WriteLine("Birinci mevzuata göre eklendi");
        }
    }
    class İkinciMevzuat : IMevzuat //İkinci mevzuat,Imevzuat implementasyonudur.
    {
        public void IslemYap()
        {
            Console.WriteLine("İkinci mevzuata göre eklendi");
        }
    }
}

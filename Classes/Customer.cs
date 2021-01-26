using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {

        private string _firstName;
        private string _lastName;
        private string _city;
        private int _id;
          
        public int Id 
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return "Mrs."+ _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName 
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string City 
        { get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }




    }
}

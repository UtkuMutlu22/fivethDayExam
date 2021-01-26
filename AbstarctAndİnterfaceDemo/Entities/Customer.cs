using AbstarctAndİnterfaceDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctAndİnterfaceDemo.Entities
{
    public class Customer:IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationaltyId { get; set; }
    }
}

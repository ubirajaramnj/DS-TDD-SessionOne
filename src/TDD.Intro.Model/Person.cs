using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Intro.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public List<Address> Addresses { get; set; }

        public Person()
        {
            Addresses = new List<Address>();
        }

        public virtual string GetSummarizedInfo()
        {
            return string.Format("Name: {0}", Name);
        }
    }

    public class Address
    {
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
    }
}

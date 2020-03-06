using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Entities
{
    public class Address
    {
        public string Adress { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address(string adress, string city, string area, string postalCode, string country)
        {
            Adress = adress;
            City = city;
            Area = area;
            PostalCode = postalCode;
            Country = country;
        }
    }
}

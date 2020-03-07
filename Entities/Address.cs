using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Entities
{
    public class Address
    {
        public int ID { get; set }
        public string AddressStr { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Entities
{
    public class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public Address Address { get; set; }        
    }
}

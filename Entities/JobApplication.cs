using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Entities
{
    public class JobApplication
    {
        public DateTime ApplicationDate { get; set; }
        public string Description { get; set; }
        public Candidate Candidate { get; set; }
    }
}

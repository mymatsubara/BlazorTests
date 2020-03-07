using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Entities
{
    public class JobVacancy
    {
        public int ID { get; set; }
        public string JobPostion { get; set; }
        public DateTime ClosingDate { get; set; }
        public Address Address { get; set; }
        public JobApplication[] JobApplications { get; set; }
    }
}

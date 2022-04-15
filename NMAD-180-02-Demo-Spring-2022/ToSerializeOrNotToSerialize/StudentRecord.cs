using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSerializeOrNotToSerialize
{
    class StudentRecord
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public int Year { get; set; }

      
        public double CumulativeGpa { get; set; }

        public StudentRecord(string name, string major,int year, double gpa)
        {
            Name = name;
            Major = major;
            Year = year;
            CumulativeGpa = gpa;
        }

        public override string ToString()
        {
            return $"Name: {Name} Major: {Major} Year:{Year} GPA: {CumulativeGpa}";
        }

    }
}

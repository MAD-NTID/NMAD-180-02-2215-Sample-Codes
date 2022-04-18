using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSV
{

    class Record
    {
        public int Fails { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Record(string name, int year, int fails)
        {
            Name = name;
            Year = year;
            Fails = fails;
        }

        public override string ToString()
        {
            return $"Name: {Name} Year: {Year} Fails:{Fails}";
        }
    }
}

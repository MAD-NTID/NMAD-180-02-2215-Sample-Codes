using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKing3._0
{
    class Friend
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public string DateAdded { get; set; }

        public Friend(string name, int age, string dateAdded)
        {
            Age = age;
            Name = name;
            DateAdded = dateAdded;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {DateAdded}";
        }
    }
}

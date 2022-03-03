using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPv2
{
    class Car
    {
        //private string engine;
         private string brand="N/A";
        //private string color;
         private int doorNumbers = -1;
        //private int year;

        public int DoorNumbers { 
            get {
                return doorNumbers; 
            } 
            set {
                if (value > 0 && value <= 4)
                    doorNumbers = value;
            } 
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (value != "")
                    brand = value;
            }
        }
        public int Year { get; set; }

    }
}

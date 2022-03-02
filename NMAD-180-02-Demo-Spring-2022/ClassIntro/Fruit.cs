using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    

    class Fruit
    {
        public string color;
        public string texture;
        public string name;

        public Fruit(string color1, string texture1, string name1)
        {
            color = color1;
            texture = texture1;
            name = name1;
        }

        public bool IsRipe()
        {
            return color.ToLower() == "yellow";
        }


    }
}

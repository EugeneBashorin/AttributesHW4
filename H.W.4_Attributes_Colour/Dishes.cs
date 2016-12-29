using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._4_Attributes_Colour
{
    class Dishes
    {
        
            public Dishes(string name, string brand, string material, string form, double cost)
            {
                Name = name;
                Brand = brand;
                Material = material;
                Form = form;
                Cost = cost;
            }
            [Сolour(ConsoleColor.DarkGreen)]
            public string Name { get; set; }

            [Сolour(ConsoleColor.Blue)]
            public string Brand { get; set; }

            [Сolour(ConsoleColor.DarkYellow)]
            public string Material { get; set; }

            public string Form { get; set; }

            [Сolour(ConsoleColor.DarkRed)]
            public double Cost { get; set; }
        
    }
}

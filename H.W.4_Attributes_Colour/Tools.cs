using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._4_Attributes_Colour
{
    class Tools
    {
        public Tools(string name, string brand, string scope, double cost)
        {
            Name = name;
            Brand = brand;
            Scope = scope;
            Cost = cost;
        }
        [Сolour(ConsoleColor.DarkGreen)]
        public string Name { get; set; }

        [Сolour(ConsoleColor.Blue)]
        public string Brand { get; set; }

        public string Scope { get; set; }

        [Сolour(ConsoleColor.DarkRed)]
        public double Cost { get; set; }
    }
}

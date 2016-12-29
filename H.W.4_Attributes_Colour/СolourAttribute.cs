using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._4_Attributes_Colour
{
    class СolourAttribute : Attribute
    {
        public СolourAttribute(ConsoleColor colour)
        {
            Colour = colour;
        }
        public ConsoleColor Colour { get; set; }
    }
}

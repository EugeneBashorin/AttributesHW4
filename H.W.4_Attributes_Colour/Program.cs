using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._4_Attributes_Colour
{
    class Program
    {
        static void Main(string[] args)
        {
            Dishes dish = new Dishes("Frying pan", "BergHOFF", "Cast iron", "Circle", 830.5);
            Tools tool = new Tools("Drill", "CAT", "Household", 1975.3);

            Console.WriteLine(dish.GetType());
            Console.WriteLine("Dishes:");
            ColourProperty.ColorPrint(dish);
            Console.WriteLine("\n\n");
            Console.WriteLine(tool.GetType());
            Console.WriteLine("Tools:");
            ColourProperty.ColorPrint(tool);
        }
    }
}

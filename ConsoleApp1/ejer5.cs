using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ejer5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año:");
            int an = int.Parse(Console.ReadLine()); 
            if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine("El año " + an + " es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " + an + " no es bisiesto.");
            }
            if (an%2 == 0)
            {
                Console.WriteLine("El año " + an + " es par.");
            }
            else
            {
                Console.WriteLine("El año " + an + " es impar.");
            }
             Console.ReadLine();

        }
    }
}

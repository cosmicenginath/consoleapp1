using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ejer
    {
        static void Main(string[] args)
        {
            string nm, cr;
            Console.Write("\nIngrese su nombre:");
            nm = Console.ReadLine();
           Console.Write("\nIngrese su carrera:");
            cr = Console.ReadLine();
            Console.WriteLine($"Hola <{nm}> ,bienvenido al curso FA, tu carrera es <{cr}>.");
            Console.ReadLine();
        }
    }
}

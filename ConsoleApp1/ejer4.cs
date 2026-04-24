using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- SISTEMA DE CONVERSACIÓN MONETARIA --");
            Console.WriteLine("Ingrese la cantidad de dinero en soles:");
            double mo = double.Parse(Console.ReadLine());
            Console.WriteLine("1. Convertir a dolares");
                        Console.WriteLine("2. Convertir a euros\n");
            Console.Write("Ingrese una opción:");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                                case 1:
                    double do1 = mo/3.75;
                    Console.WriteLine("La cantidad de dinero en dolares es: " + do1);
                    break;
                    case 2:
                    double eu1 = mo/4.10;
                    Console.WriteLine("La cantidad de dinero en euros es: " + eu1);
                    break;
                    default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        }
    }
}

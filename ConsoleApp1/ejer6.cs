using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--CALCULADORA DE ÁREA DE FIGURAS GEOMÉTRICAS--");
            Console.WriteLine("1. Área de un círculo");
            Console.WriteLine("2. Área de un triángulo");
            Console.WriteLine("3. Área de un rectángulo\n");
            Console.Write("4. Área de un cuadrado");
            Console.Write("\nIngrese una opción:");
            double op = Convert.ToInt32(Console.ReadLine());
            switch (op)
                {
                case 1:
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double r = double.Parse(Console.ReadLine());
                    double areaCirculo = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("El área del círculo es: " + areaCirculo);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del triángulo:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo:");
                    double h = double.Parse(Console.ReadLine());
                    double areaTriangulo = (b * h) / 2;
                    Console.WriteLine("El área del triángulo es: " + areaTriangulo);
                    break;
                case 3:
                    Console.WriteLine("Ingrese la base del rectángulo:");
                    double baseRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo:");
                    double alturaRectangulo = double.Parse(Console.ReadLine());
                    double areaRectangulo = baseRectangulo * alturaRectangulo;
                    Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoCuadrado = double.Parse(Console.ReadLine());
                    double areaCuadrado = Math.Pow(ladoCuadrado, 2);
                    Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;

            }
    }
}

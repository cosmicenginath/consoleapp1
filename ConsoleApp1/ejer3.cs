using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ejer3

    {
        static void Main(string[] args)
        {

            string sum, res, mul, div;
            int a, b;
            Console.Write("\nIngrese el primer numero:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el segundo numero:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEscoja la operación aritmetica que desea realizar:");
            if sum = Console.ReadLine()
             {
                res = Convert.ToString(a + b);
                Console.WriteLine("\nEl resultado de la suma es:" + res);
            }
            else if (res = Console.ReadLine() == "resta")
             {
                res = Convert.ToString(a - b);
                Console.WriteLine("\nEl resultado de la resta es:" + res);
            }
            else if (mul = Console.ReadLine() == "multiplicacion")
             {
                res = Convert.ToString(a * b);
                Console.WriteLine("\nEl resultado de la multiplicacion es:" + res);
            }
            else if (div = Console.ReadLine() == "division")
             {
                res = Convert.ToString(a / b);
                Console.WriteLine("\nEl resultado de la division es:" + res);
             }
            else
            {
                
            }




        }
}

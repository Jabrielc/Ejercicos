using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificación_de_números_012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("Hay ceros");
            }
            else if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                Console.WriteLine("Todos son positivos");
            }
            else if (num1 < 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("Todos son negativos");
            }
            else
            {
                Console.WriteLine("Son mixtos");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_triángulo_017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Digite el lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Digite el lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Equilátero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Isósceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
            Console.ReadLine();
        }
    }
}

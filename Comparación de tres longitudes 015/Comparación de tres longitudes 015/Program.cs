using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparación_de_tres_longitudes_015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                Console.WriteLine("Pueden Formar Un Triangulo");
            }
            else
            { 
                Console.WriteLine("No Pueden Formar un Triangulo");
            }
             Console.ReadLine();
        }
    }
}

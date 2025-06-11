using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_positivo__negativo_o_cero_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else
            {
                Console.WriteLine("Es cero");
            }
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Múltiplo_de_5_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 5 == 0)
            {
                Console.WriteLine("Multiplo de 5");
            }
            else
            { 
            Console.WriteLine("No es multiplo de 5");
            }
        Console.ReadLine(); 
        }
    }
}

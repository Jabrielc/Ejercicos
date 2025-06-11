using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_par_o_impar_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es par");
            }

            else
            { 
            Console.WriteLine("Es impar");
            }
        Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_mayor_entre_dos_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"El número mayor es {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El número mayor es {numero2}");
            }

            else
            { 
            Console.WriteLine("Son iguales");
            }
            Console.ReadLine();

        }
    }
}

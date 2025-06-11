using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversión_de_calificaciones_014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su calificación: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 90)
            {
                Console.WriteLine("A");
            }

            else if (nota >= 80)
            {
                Console.WriteLine("B");
            }

            else if (nota >= 70)
            {
                Console.WriteLine("C");
            }

            else if (nota >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        Console.ReadLine();
        }
    }
}

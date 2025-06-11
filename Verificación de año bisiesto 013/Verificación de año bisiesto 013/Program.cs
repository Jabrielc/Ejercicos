using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificación_de_año_bisiesto_013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un año: ");
            int año = int.Parse(Console.ReadLine());

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine("Es bisiesto");
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }
            Console.ReadLine();
        }
    }
}

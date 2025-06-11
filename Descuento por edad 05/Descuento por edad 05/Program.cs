using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuento_por_edad_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 60)
            {
                Console.WriteLine("El descuento del 50% si aplica");
            }
            else 
            {
            Console.WriteLine("El descuento no aplica");
            }

            Console.ReadLine();
        }
    }
}

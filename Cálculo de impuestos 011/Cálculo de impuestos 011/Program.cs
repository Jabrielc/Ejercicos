using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_impuestos_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su sueldo mensual: ");
            double sueldo = double.Parse(Console.ReadLine());

            double impuesto = 0;

            if (sueldo < 10000)
            {
                impuesto = 0;
            }
            else if (sueldo <= 30000)
                impuesto = sueldo * 0.10;

            else 
            {
                sueldo = impuesto * 0.20;       
            }
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
            Console.ReadLine();
        }
    }
}

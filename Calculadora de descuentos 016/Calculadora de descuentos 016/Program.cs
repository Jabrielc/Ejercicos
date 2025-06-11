using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_descuentos_016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el precio de un producto: ");
            double precio = double.Parse(Console.ReadLine());
            double descuento = 0;

            if (precio >= 50 && precio <= 100)
            {
                descuento = precio * 0.05;
            }
            else if (precio > 100)
            {
                descuento = precio * 0.10;
            }

            Console.WriteLine($"El descuento es: {descuento}");
            Console.WriteLine($"El precio final es: {precio - descuento}");
            Console.ReadLine();

        }
    }
}

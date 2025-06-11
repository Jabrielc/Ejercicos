using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificación_de_ángulos_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor del ángulo en grados: ");
            int angulo = int.Parse(Console.ReadLine());

            if (angulo < 90)
            {
                Console.WriteLine("Es un ángulo agudo");
            }
            else if (angulo == 90)
            {
                Console.WriteLine("Es un ángulo recto");
            }
            else if (angulo < 180)
            {
                Console.WriteLine("Es un ángulo obtuso");
            }
            else if (angulo == 180)
            {
                Console.WriteLine("Es un ángulo llano");
            }
            else
            {
                Console.WriteLine("Ángulo inválido");

            }
        Console.ReadLine();
        }
    }
}
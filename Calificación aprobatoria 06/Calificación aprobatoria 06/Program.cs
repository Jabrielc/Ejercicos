using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificación_aprobatoria_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la calificación: ");
            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 60)
            {
                Console.WriteLine("Aprobaste");
            }

            else 
            {
            Console.WriteLine("Reprobaste");
            }
        Console.ReadLine();
        }
    }
}

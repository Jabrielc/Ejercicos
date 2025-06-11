using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_de_temperatura_018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la temperatura en °C: ");
            int tempe = int.Parse(Console.ReadLine());

            if (tempe < 0)
            {
                Console.WriteLine("Hace mucho frío");
            }
            else if (tempe <= 20)
            {
                Console.WriteLine("Clima fresco");
            }
            else if (tempe <= 30)
            {
                Console.WriteLine("Clima agradable");
            }
            else
            {
                Console.WriteLine("Hace mucho calor");
            }
            Console.ReadLine();
        }
    }
}

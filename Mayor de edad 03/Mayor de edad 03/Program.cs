using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_edad_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad: ");
            }
            else 
            { 
            Console.WriteLine("Es menor de edad: ");
            }
        Console.Read();
        }
    }
}

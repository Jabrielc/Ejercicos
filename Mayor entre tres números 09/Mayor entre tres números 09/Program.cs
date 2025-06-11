using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_entre_tres_números_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el primer número: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo número: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer número: ");
            int C = int.Parse(Console.ReadLine());
            int mayor = A;
            if (B > mayor )
            { 
            mayor = B;
            }
            if (C > mayor)
            { 
            mayor = C;
            }
            Console.WriteLine($"El número mayor es: {mayor}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificación_de_IMC_020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            
            Console.Write("Digite la Altura en Metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidad");
            }
            Console.ReadLine();
        }
    }
}

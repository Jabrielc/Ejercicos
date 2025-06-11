using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Día_de_la_semana_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número del 1 al 7: ");
            int Dia = int.Parse(Console.ReadLine());

            switch (Dia) 
            { 
            case 1:
                    Console.WriteLine("Lunes");
                    break;
            case 2:
                    Console.WriteLine("Martes");
                    break;
            case 3:
                    Console.WriteLine("Míercoles");
                    break;
            case 4:
                    Console.WriteLine("Jueves");
                    break;
            case 5:
                    Console.WriteLine("Viernes");
                    break;
            case 6:
                    Console.WriteLine("Sabado");
                    break;
            case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Número inválido");
                    break;
            }
               Console.ReadLine();


        }
    }
}

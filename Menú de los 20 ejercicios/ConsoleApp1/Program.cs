using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {                 
class Programa
        {
            static void Main()
            {
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("===== MENÚ DE LOS 20 EJERCICIOS =====");
                    Console.WriteLine("1. Número positivo, negativo o cero");
                    Console.WriteLine("2. Verificar si es mayor de edad");
                    Console.WriteLine("3. Múltiplo de 5 y par/impar");
                    Console.WriteLine("4. Evaluar calificación (Aprobado o Reprobado)");
                    Console.WriteLine("5. Día de la semana");
                    Console.WriteLine("6. Número mayor entre dos");
                    Console.WriteLine("7. Número mayor entre tres");
                    Console.WriteLine("8. Tipo de ángulo");
                    Console.WriteLine("9. Cálculo de impuestos y descuento por edad");
                    Console.WriteLine("10. Clasificación de ángulos");
                    Console.WriteLine("11. Verificación de año bisiesto");
                    Console.WriteLine("12. Conversión de calificaciones");
                    Console.WriteLine("13. Verificar si forma triángulo");
                    Console.WriteLine("14. Calculadora de descuentos");
                    Console.WriteLine("15. Tipo de triángulo");
                    Console.WriteLine("16. Evaluación de temperatura");
                    Console.WriteLine("17. Turno por hora");
                    Console.WriteLine("18. Clasificación de IMC");
                    Console.WriteLine("0. Salir");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                   
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1: PositivoNegativoCero(); break;
                        case 2: MayorDeEdad(); break;
                        case 3: MultiploYParImpar(); break;
                        case 4: EvaluarCalificacion(); break;
                        case 5: DiaDeLaSemana(); break;
                        case 6: MayorDeDos(); break;
                        case 7: MayorDeTres(); break;
                        case 8: TipoDeAngulo(); break;
                        case 9: ImpuestoYDescuento(); break;
                        case 10: PositivosNegativosMixtos(); break;
                        case 11: AñoBisiesto(); break;
                        case 12: CalificacionLetra(); break;
                        case 13: FormarTriangulo(); break;
                        case 14: DescuentoProducto(); break;
                        case 15: TipoTriangulo(); break;
                        case 16: EvaluarTemperatura(); break;
                        case 17: TurnoHora(); break;
                        case 18: CalcularIMC(); break; 
                        case 19: DescuentoPorEdad(); break;
                        default: Console.WriteLine("Opción inválida."); break;
                    }
                    if (opcion != 0)
                    {
                        Console.WriteLine("\nPresiona una tecla para volver al menú: ");
                        Console.ReadKey();
                    }
                } while (opcion != 0);
            }

            static void PositivoNegativoCero()
            {
                Console.Write("Digite un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0) Console.WriteLine("Es positivo");
                
                else if (numero < 0) Console.WriteLine("Es negativo");
              
                else Console.WriteLine("Es cero");
            }

            static void MayorDeEdad()
            {
                Console.Write("Digite su edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18) Console.WriteLine("Es mayor de edad");

                else Console.WriteLine("Es menor de edad");
            }

            static void MultiploYParImpar()
            {
                Console.Write("Digite un número: ");
                int numero = int.Parse(Console.ReadLine());
               
                if (numero % 5 == 0)
                    Console.WriteLine($"El número {numero} es múltiplo de 5.");

                else
                    Console.WriteLine($"El número {numero} no es múltiplo de 5.");

                if (numero % 2 == 0)
                    Console.WriteLine("Es par");

                else
                    Console.WriteLine("Es impar");
            }

            static void EvaluarCalificacion()
            {
                Console.Write("Digite la calificación: ");
                int calificacion = int.Parse(Console.ReadLine());

                if (calificacion >= 60) Console.WriteLine("Aprobaste");

                else Console.WriteLine("Reprobaste");
            }

            static void DiaDeLaSemana()
            {
                Console.Write("Digite un número del 1 al 7: ");
                int dia = int.Parse(Console.ReadLine());

                switch (dia)
                {
                    case 1: Console.WriteLine("Lunes"); break;
                    case 2: Console.WriteLine("Martes"); break;
                    case 3: Console.WriteLine("Miércoles"); break;
                    case 4: Console.WriteLine("Jueves"); break;
                    case 5: Console.WriteLine("Viernes"); break;
                    case 6: Console.WriteLine("Sábado"); break;
                    case 7: Console.WriteLine("Domingo"); break;
                    default: Console.WriteLine("Número inválido"); break;
                }
            }

            static void MayorDeDos()
            {
                Console.Write("Digite un número: ");
                int num1 = int.Parse(Console.ReadLine());
               
                Console.Write("Digite otro número: ");
                int num2 = int.Parse(Console.ReadLine());
               
                if (num1 > num2)
                    Console.WriteLine($"El número mayor es {num1}");
                
                else if (num2 > num1)
                    Console.WriteLine($"El número mayor es {num2}");
               
                else
                    Console.WriteLine("Son iguales");
            }

            static void MayorDeTres()
            {
                Console.Write("Digite el primer número: ");
                int A = int.Parse(Console.ReadLine());

                Console.Write("Digite el segundo número: ");
                int B = int.Parse(Console.ReadLine());

                Console.Write("Digite el tercer número: ");
                int C = int.Parse(Console.ReadLine());

                int mayor = A;
               
                if (B > mayor) mayor = B;
                
                if (C > mayor) mayor = C;
               
                Console.WriteLine($"El número mayor es: {mayor}");
            }

            static void TipoDeAngulo()
            {
                Console.Write("Digite el valor del ángulo en grados: ");
                int angulo = int.Parse(Console.ReadLine());

                if (angulo < 90)
                    Console.WriteLine("Es un ángulo agudo");

                else if (angulo == 90)
                    Console.WriteLine("Es un ángulo recto");

                else if (angulo < 180)
                    Console.WriteLine("Es un ángulo obtuso");

                else if (angulo == 180)
                    Console.WriteLine("Es un ángulo llano");

                else
                    Console.WriteLine("Ángulo inválido");
            }

            static void ImpuestoYDescuento()
            {
                Console.Write("Digite su salario mensual: ");
                double salario = double.Parse(Console.ReadLine());

                double impuesto = 0;

                if (salario < 10000)
                    impuesto = 0;
                
                else if (salario <= 30000)
                    impuesto = salario * 0.10;
               
                else
                    impuesto = salario * 0.20;

                Console.WriteLine($"Salario mensual: {salario:C}");
                Console.WriteLine($"Impuesto aplicado: {impuesto:C}");
                Console.WriteLine($"Salario después de impuestos: {(salario - impuesto):C}");

               
            }
            static void DescuentoPorEdad()
            {
                Console.Write("Digite  tu edad: ");
                int edad = int.Parse(Console.ReadLine());
                
                if (edad > 60)
                    Console.WriteLine(" Aplicas para un descuento del 50%!");
                
                else
                    Console.WriteLine("No aplicas para el descuento.");
            }
            static void PositivosNegativosMixtos()
            {
                Console.Write("Digite el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite el tercer número: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num1 == 0 || num2 == 0 || num3 == 0)
                    Console.WriteLine("Hay ceros");
               
                else if (num1 > 0 && num2 > 0 && num3 > 0)
                    Console.WriteLine("Todos son positivos");
               
                else if (num1 < 0 && num2 < 0 && num3 < 0)
                    Console.WriteLine("Todos son negativos");
               
                else
                    Console.WriteLine("Son mixtos");
            }

            static void AñoBisiesto()
            {
                Console.Write("Ingresa un año: ");
                int año = int.Parse(Console.ReadLine());

                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    Console.WriteLine("Es un año bisiesto.");
               
                else
                    Console.WriteLine("No es un año bisiesto.");
            }

            static void CalificacionLetra()
            {
                Console.Write("Digite  la calificación (0-100): ");
                int calificacion = int.Parse(Console.ReadLine());

                if (calificacion >= 90)
                    Console.WriteLine("Calificación: A");
               
                else if (calificacion >= 80)
                    Console.WriteLine("Calificación: B");
               
                else if (calificacion >= 70)
                    Console.WriteLine("Calificación: C");
               
                else if (calificacion >= 60)
                    Console.WriteLine("Calificación: D");
                
                else
                    Console.WriteLine("Calificación: F");
            }

            static void FormarTriangulo()
            {
                Console.Write("Digite Lado 1: ");
                double A = double.Parse(Console.ReadLine());

                Console.Write("Digite Lado 2: ");
                double P = double.Parse(Console.ReadLine());
                Console.Write("Digite Lado 3: ");

                double M = double.Parse(Console.ReadLine());

                if (A + P > M && A + M > P && P + M > A)
                    Console.WriteLine("Las longitudes pueden formar un triángulo.");
               
                else
                    Console.WriteLine("No pueden formar un triángulo.");
            }

            static void DescuentoProducto()
            {
                Console.Write("Digite  el precio del producto: ");
                double precio = double.Parse(Console.ReadLine());
                
                double descuento = 0;

                if (precio >= 50 && precio <= 100)
                    descuento = precio * 0.05;
               
                else if (precio > 100)
                    descuento = precio * 0.10;

                double total = precio - descuento;
                
                Console.WriteLine($"Descuento aplicado: {descuento:C}");
               
                Console.WriteLine($"Precio final: {total:C}");
            }

            static void TipoTriangulo()
            {
                Console.Write("Digite Lado A: ");
                double A = double.Parse(Console.ReadLine());
                Console.Write("Digite Lado B: "); 

                double B = double.Parse(Console.ReadLine());
                Console.Write("Digite Lado C: ");

                double C = double.Parse(Console.ReadLine());

                if (A == B && B == C)
                    Console.WriteLine("Triángulo equilátero.");
                
                else if (A == B || A == C || B == C )
                    Console.WriteLine("Triángulo isósceles.");
              
                else
                    Console.WriteLine("Triángulo escaleno.");
            }

            static void EvaluarTemperatura()
            {
                Console.Write("Digite la Temperatura en °C: ");
                double temp = double.Parse(Console.ReadLine());

                if (temp < 0)
                    Console.WriteLine("Hace mucho frío");
               
                else if (temp <= 20)
                    Console.WriteLine("Clima fresco");
                
                else if (temp <= 30)
                    Console.WriteLine("Clima agradable");
                
                else
                    Console.WriteLine("Hace mucho calor");
            }

            static void TurnoHora()
            {
                Console.Write("Digite la Hora: ");
                int Hora = int.Parse(Console.ReadLine());

                if (Hora >= 6 && Hora <= 11)
                    Console.WriteLine(" Mañana");
                
                else if (Hora >= 12 && Hora <= 17)
                    Console.WriteLine("Tarde");
                
                else if (Hora >= 18 && Hora <= 23)
                    Console.WriteLine("Noche");
                
                else
                    Console.WriteLine(" Madrugada");
            }

            static void CalcularIMC()
            {
                Console.Write("Digite su Peso en (kg): ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Digite  su Altura en  (m): ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);             

                if (imc < 18.5)
                    Console.WriteLine("Bajo peso");
                
                else if (imc <= 24.9)
                    Console.WriteLine("Normal");
                
                else if (imc <= 29.9)
                    Console.WriteLine("Sobrepeso");
                
                else
                    Console.WriteLine("Obesidad");
            }
        }

    }
}


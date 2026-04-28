using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_while_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            Console.WriteLine("Ingrese números enteros positivos para sumar.");
            Console.WriteLine("Ingrese un número negativo para finalizar.");

            do
            {
                Console.Write("Ingrese un número: ");
                // Lee la entrada y la convierte a entero
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero >= 0)
                    {
                        suma += numero; // Suma si es positivo o cero
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo.");
                    numero = 0; // Continúa el bucle
                }

            } while (numero >= 0); // Termina si el número es negativo


            Console.WriteLine($"La suma total de los números positivos es: {suma}");
        }
    }
}    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_vectores_tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[15];
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine($"ingrese la palabra {i + 1} con indice {i}");
                palabras[i] = (Console.ReadLine());
                Console.WriteLine($" la palabra ingresado es {palabras[i]}");
            }
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine("Vector Original: " + string.Join(", ", palabras));


            string[] invertido = palabras.Reverse().ToArray();


            Console.WriteLine("Vector Invertido: " + string.Join(", ", invertido));
        }
    }
}

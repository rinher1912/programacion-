using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace taller_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
pantalla la suma de los elementos de cada columna.*/
            /*int[,] matriz = new int[10, 20];
            Random random = new Random();
            for(int i =0; i<matriz.GetLength(0); i++)
            {
                for(int j=0; j<matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }
            for (int j=0; j<matriz.GetLength(1); j++)
            {
                int sumaColumna = 0;
                for (int i = 0; i< matriz.GetLength(0); i++)
                {
                    sumaColumna += matriz[i, j];
                }
                Console.WriteLine($"Suma de la columna {j + 1}:{sumaColumna}");
            }
            Console.ReadLine();      */
            /* 2.Desarrollar un programa que crea una matriz de n filas m columnas, el usuario ingresa
caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
matriz con el intercambio de filas.*/

            /* Console.WriteLine("Ingrese el número de filas:");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el número de columnas:");
             int m = int.Parse(Console.ReadLine());
             char[,] matriz = new char[n, m];

             for(int i=0; i<matriz.GetLength(0); i++)
             {
                 for(int j=0; j<matriz.GetLength(1); j++)
                 {
                     Console.WriteLine($"Ingrese el caraccter para la posicion [{i},{j}]:");
                     matriz[i, j] = Console.ReadKey().KeyChar;
                     Console.WriteLine();
                 }
             }
             char[] primerafila = new char[m];
             char[] ultimafila = new char[m];
             for(int j=0; j<matriz.GetLength(1); j++)
             {
                 primerafila[j] = matriz[0, j];
                 ultimafila[j]= matriz[matriz.GetLength(0) - 1, j];
                 matriz[0, j] = ultimafila[j];
                 matriz[matriz.GetLength(0) - 1, j] = primerafila[j];
             }

             Console.WriteLine("Matriz original:");
             for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     Console.Write(matriz[i, j] + " ");
                 }
                 Console.WriteLine();
             }*/

            /* 3.Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
 5x5 llena de números aleatorios.
 El algoritmo debe permitir: 
  Usa la función Random para generar los números aleatorios.
  Crea un arreglo adicional para almacenar la frecuencia de cada número.
  Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número*/
            int[,] matriz = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                }
            }
            int[] frecuencia = new int[10];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int numero = matriz[i, j];
                    frecuencia[numero - 1]++;
                }
            }
            Console.WriteLine("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Frecuencia de cada número del 1 al 10:");
            for (int i = 0; i < frecuencia.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]}");
            }
            Console.ReadLine();
        }
    }
}

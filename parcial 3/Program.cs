using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*Análisis numérico de una matriz dinámica
             Implemente un programa que permita a un usuario definir, llenar y analizar una matriz de números enteros, con el objetivo de obtener estadísticas numéricas específicas.
              Requisitos del programa:
               Definición de la matriz:
               Solicite al usuario ingresar el número de filas n y columnas m de la matriz.
                 Ambos valores deben ser enteros mayores o iguales a 2 y menores o iguales a 10.
                 Si el usuario ingresa valores fuera del rango, debe mostrarse un mensaje de error y volver a solicitar la entrada.
               Ingreso de elementos:
                    Permita al usuario ingresar los elementos de la matriz manualmente, uno a uno, indicando la posición actual (fila, columna).
                  Cada número debe ser un entero que puede ser positivo, negativo o cero.
                    Visualización de la matriz:
                   Una vez completado el ingreso, mostrar la matriz en pantalla con un formato tabular.
                   Procesamiento y estadísticas:
                   Calcular y mostrar en pantalla lo siguiente:
                    La suma de todos los números pares ingresados en la matriz.
                    La suma de todos los números impares.
                  La cantidad de números negativos encontrados en la matriz.
                       La cantidad total de ceros.
                    El promedio general de todos los valores ingresados.
                 Formato de salida:
                  Cada resultado debe mostrarse con un mensaje descriptivo.
                   Consideraciones técnicas:
                    El cálculo del promedio debe considerar todos los elementos de la matriz.*/
            int filas = 0;
            int columnas = 0;
            Console.WriteLine("ingrese un numero que represente las filas de la matriz  entre 2 y 10 enteros");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero que represente las columnas  de la matriz entre 2 y 10 enteros");
            columnas = int.Parse(Console.ReadLine());
            int sumpar = 0;
            int sumimpar = 0;
            float promedio = 0f;
            float contadortotal=0f;
            int contador0 = 0;
            int contadornegativo = 0;
            float total = 0f;
            do
            {
                Console.WriteLine("ingrese un numero que represente las filas de la matriz  entre 2 y 10 enteros");
                filas = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese un numero que represente las columnas  de la matriz entre 2 y 10 enteros");
                columnas = int.Parse(Console.ReadLine());
            }
            while (filas < 2 && 10 < filas && columnas < 2 && 10 < columnas);

            int [,] matriz = new int[filas, columnas];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"ingrese el valor que va en la fila {i} con columna {j}");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                    
                }
            }
            Console.WriteLine("su matriz es la siguiente");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    
                   Console.Write (matriz[i,j] + " | ");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    total += matriz[i, j];
                    contadortotal++;

                    if (matriz[i,j]== 0)
                    {
                        contador0++;
                    }
                    else if (matriz[i,j] % 2 == 0)
                    {
                        sumpar += matriz[i, j];
                        if (matriz[i,j] <=0)
                        {
                            contadornegativo++;
                        }
                    }
                    else if (matriz[i, j] % 2 !=0)
                    {
                        sumimpar += matriz[i, j];
                        if (matriz[i, j] <= 0)
                        {
                            contadornegativo++;
                        }

                    }


                }
               
            }
            promedio = (total / contadortotal);
            Console.Write($" lasuma de todos los datos es {total} y el total de datos es {contadortotal}");
            Console.Write($" el promedio de los datos es {promedio}");
            Console.WriteLine($"la suma de numeros impares es{sumimpar} y la de numeros pares es {sumpar}");
            Console.WriteLine($"el total de numeros negativos es {contadornegativo}");


        }
    }
}

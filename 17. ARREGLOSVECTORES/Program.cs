using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ARREGLOSVECTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 16;
            numeros[2] = 17;
            numeros[3] = 18;
            numeros[4] = 19;
            //numeros[5] = 20; la posicion es 6 con indice 5 no existe porque el rango del vector es 5
            Console.WriteLine($"el valor almacenado en la posicion 3 con indice 2 es {numeros[2]}");

            // RECORRER EL VECTOR PARA LLENARLO 

            string[] nombres = new string[5];
            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine($"ingrese el nombre {i + 1} con indice {i}");
                nombres[i] = Console.ReadLine();
            }
            
            // recorrer el vector para recuperar los datos almacenados en el 
            Console.Clear();
            char[] simbolos = new char[] { '!', '#', '$', '%', '&', 'q', };
            for (int i = 0; i < simbolos.Length; i++);
            {
                Console.Write(simbolos[i] + '|');
            }*/

            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
                Console.Write(numeros[i]);
            }
            Console.Clear();
            int[] numeros2 = new int[15];
            int posicion = 0;
            int mayor = 0;
            int menor = 0;
            int posicion2 = 15;
            for (int g = 0; g < numeros2.Length; g++)
            {
                Console.WriteLine($"ingrese el numero {g + 1} con indice {g}");
                numeros2[g] =int.Parse( Console.ReadLine());
                Console.WriteLine($"el numero ingresado es {numeros2[g]}");
                

            }
            mayor = numeros2[0];
            menor = numeros2[0];
            for (int g = 1; g < numeros2.Length; g++)
            {
                if (numeros[g] < menor)
                {
                    menor = numeros[g];
                    posicion = g;
                }
            }
            for (int g = 1; g < numeros2.Length; g++)
            {
                if (numeros[g] > mayor)
                {
                    mayor = numeros[g];
                    posicion2 = g;
                }
                

            }
            
            Console.WriteLine($"\nEl menor número es: {menor}");
            Console.WriteLine($"Se encuentra en la posición (índice): {posicion}");
            Console.Write($"los numeros ingresado es {numeros2}");
        }
        
    }
}

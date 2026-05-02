using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar algoritmo que permita obtener la suma de todos los numeros impares hasta el 99
            int acumulador = 0;
            int contador = 1;

            while (contador <= 99)
            {
                acumulador += contador;
                contador += 2;
            }
            Console.WriteLine("La suma de los numeros impares del 1 hasta el 99 es: " + acumulador);

            //Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir. El algoritmo debe escribir en pantalla: La catidad de numeros introducidos que son mayores que 0. La cantidad de numeros introducidos menores que 0. La cantidad de numeros iguales a 0

            /*int cantidadNumeros = 0;
            int contador = 1;
            int numero =0;
             int ceros = 0;
            int mayoresCero = 0;
                int menoresCero = 0;

            Console.WriteLine("Ingrese la cantidd de numeros a ingresar");

            cantidadNumeros = int.Parse(Console.ReadLine());

            while (contador <= cantidadNumeros)
            {
                Console.WriteLine($"Ingrese el valor del numero {contador}");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    ceros++;
                }
                else
                {
                    if (numero > 0)
                    {
                        mayoresCero++;
                    }
                    else
                    {
                        menoresCero++;
                    }
                }
                    contador++;
            }
            Console.WriteLine($"La cantidad de numeros introducidos que son mayores que 0 es: {mayoresCero}, la cantidad menores que 0 es: {menoresCero}, la cantidad de numeros iguales a 0 es: {ceros}");*/
            // Realizar un algoritmo para determinar cuanto ahorrara una persona en un año, si al final de cada mes deposita cantidades variables de dinero; ademas, se quiere saber cuanto lleva ahorrado cada mes.


            /* int contadorMeses = 1;
             float acumuladorAhorro = 0;
             float ahorro = 0;


             while (contadorMeses <= 12)
             {
                 Console.WriteLine($"En el mes {contadorMeses}, cuanto desea ahorrar");
                 ahorro = Single.Parse(Console.ReadLine());

                 acumuladorAhorro+=ahorro;

                 Console.WriteLine($"Este mes usted ahorro ${ahorro}, para el mes {contadorMeses} usted tine ahorrado $ {acumuladorAhorro}");

                 contadorMeses++;
            }
                 */
        }

    }
}



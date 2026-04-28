using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DO_WHILE_EXERCISES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contadorN = 1;
            int contador = 1;
            int contadorDiv = 0;

            do
            {
                do
                {
                    if (contadorN % contador == 0)
                    {
                        contadorDiv++;
                    }
                    contador++;
                } while (contador <= contadorN);
                contador = 1;
                if (contadorDiv == 2)
                {
                    Console.WriteLine(contadorN);
                }
                contadorDiv = 0;
                contadorN++;
            } while (contadorN <= 100);*/
            string operacion = "";
            float num1 = 0f;
            float num2 = 0f;
            float resultado = 0f;
            string respuesta = "";
            do
            {

                
                Console.WriteLine("ingrese una operacion entre suma , resta ,division y multiplicacion");
                operacion = Console.ReadLine();
                switch (operacion)
                {
                    case "suma":
                        Console.WriteLine("ingrese el numero 1 ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("ingrese el numero 2 ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine($"el resultado es {resultado}");
                        Console.WriteLine("desea continuar haciendo operaciones? YES=si NO=no");
                        respuesta = Console.ReadLine();
                        break;
                    case "resta":
                        Console.WriteLine("ingrese el numero 1 ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("ingrese el numero 2 ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"el resultado es {resultado}");
                        Console.WriteLine("desea continuar haciendo operaciones? YES=si NO=no");
                        respuesta = Console.ReadLine();
                        break;
                    case "division":
                        Console.WriteLine("ingrese el numero 1 ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("ingrese el numero 2 ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine($"el resultado es {resultado}");
                        Console.WriteLine("desea continuar haciendo operaciones? Y=si N=no");
                        respuesta = Console.ReadLine();
                        break;
                    case "multiplicacion":
                        Console.WriteLine("ingrese el numero 1 ");
                        num1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("ingrese el numero 2 ");
                        num2 = Convert.ToSingle(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"el resultado es {resultado}");
                        Console.WriteLine("desea continuar haciendo operaciones? Y=si N=no");
                        respuesta = Console.ReadLine();
                        break;
                    default:
                        break;

                    
                }
            }
            while (respuesta == "YES");
        }
    }
}

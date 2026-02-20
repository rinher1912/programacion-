using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Condicionales_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string nombre = "";
            float sueldo = 0.0f;
            Console.WriteLine("ingrese el nombre del usuario");
            nombre=Console.ReadLine(); // lo que llega desde la consola, es de tipo string
            Console.WriteLine("ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo>=3000)
            {
                Console.WriteLine($"la persona {nombre}, debe abonar impuestos");
            }*/

            int edad = 0;
            Console.WriteLine("ingrese la edad del usuario");
            edad=Convert.ToByte (Console.ReadLine());
            if (edad>=18)
            {
                Console.WriteLine("bienvenido a mi red");

            }
        }
    }
}

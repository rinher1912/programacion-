using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_programacion_modular
{
    internal class Program
    { static int añoactual = 2026;
        static void Main(string[] args)
        {
            string nombre = "";
            string apellido = "";
            Console.WriteLine("cual es su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("cual es su apellido");
            apellido = Console.ReadLine();
            saludo(nombre, apellido);


            static void borrapantalla()
            {
                Console.Clear();
            }
            static void saludo(string nombre, string apellido)
            {
                Console.WriteLine($"Bienvenido {nombre} {apellido}, a la programacion modular");
            }

            static int edadañonacimiento()
            {
                int añonacimiento
            }

        }
    }
}

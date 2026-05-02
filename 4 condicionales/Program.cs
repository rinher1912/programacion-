using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }

            else if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }

            else
            {
                Console.WriteLine("El numero es cero");
            }
            ;
        }
    }
}

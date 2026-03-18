using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_acumulador_y_contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int contador = 1;
             int acumulador = 0;
             while (contador <= 5)
             {
                 acumulador += contador;
                 Console.WriteLine($"contador:{contador} - Acumulador: {acumulador}");
                 contador++;
             }
             Console.WriteLine($"la suma de los 5 numeros enteros es {acumulador}");
           */
            int num =0;
            int contador = 1;
            int acumulador =1;
            

            Console.WriteLine("ingrese un numero");
            num= Convert.ToInt16(Console.ReadLine());
            while (contador <= num)
            {
                acumulador *= contador ;
                contador++;
                
            }
            Console.WriteLine($"el factorial de {num} es {acumulador} ");
       }
    }
}

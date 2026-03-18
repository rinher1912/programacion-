using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_do_while_2
{
    internal class Program
    {
        static void Main(string[] args)
        { int saldo = 0;
            string usuario = "";
            float ncuenta = 0;
            string respuesta = "";
            
            do
            {
                Console.WriteLine(" cual su nombre de usuario ");
                usuario = Console.ReadLine();
                Console.WriteLine(" cual su numero de cuenta  ");
                ncuenta = int.Parse(Console.ReadLine());
                Console.WriteLine(" cual su saldo de cuenta  ");
                saldo = int.Parse(Console.ReadLine());
                if (saldo>300000)
                {
                    Console.WriteLine($" el usuario {usuario} con numero de  cuenta {ncuenta} y saldo {saldo}  es apto para el credito  ");
                }
                else
                {
                    if (saldo <= 300000)
                    {
                        Console.WriteLine($" el usuario {usuario} con numero de  cuenta {ncuenta} y saldo {saldo} no es apto para el credito  ");
                  }
                }
                Console.WriteLine($"el usuario {usuario}  desea consultar saldo y cuenta de otro usuario . YES= si NOes= no");
                 respuesta = Console.ReadLine();
            }
            while (respuesta== "YES");
            
        }
    }
}

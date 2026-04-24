using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mostrarmenu();
            int opcion = capturaropcion();
            realizaroperacion(opcion);

        }
        static void mostrarmenu()
        {
            Console.WriteLine("----------MEMU---------------------");
            Console.WriteLine("1 suma               2 resta");
            Console.WriteLine("3 multiplicacion     3 division");
            Console.WriteLine("-----------------------------------");
        }
        static int capturaropcion()
        {
            Console.WriteLine("ingrese el numero de la operacion");
            return int .Parse(Console.ReadLine());  
        }
        static void borrarpantalla() 
        {
            Console.Clear();
        }
        static void realizaroperacion(int opcion) 
        {
            switch (opcion) 
            {
                case 1:
                    suma();
                    break;
                case 2:
                    resta();
                    break;
                case 3:
                    multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
            }
        }
        static void Division()
        { Console.WriteLine("usted va a dividir"); }
        static void multiplicacion()
        { Console.WriteLine("usted va a multiplicar"); }
        static void suma()
        { Console.WriteLine("usted va a sumar"); }
        static void resta()
        { Console.WriteLine("usted va a resta"); }

    }
}

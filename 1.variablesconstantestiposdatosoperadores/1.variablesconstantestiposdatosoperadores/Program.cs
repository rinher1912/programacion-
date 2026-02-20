using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.variablesconstantestiposdatosoperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES NUMERICOS
            // CAMBIO DE SIGNO 
            int dato1 = 5;
            int dato2 = -dato1;
            Console.Write(dato1 + "//" + dato2);
            int dato3 = 5 + 6;
            int dato4 = 120 + 231;
            int dato5 = 12 * 56;
            float dato6 = (float)5 / 3;
            Console.Write("\nSuma: {0}, Resta: {1}, multiplicacion: {2},Division: {3}", dato3, dato4, dato5, dato6);
            //incremento decremento
            dato3++; //dato3= dato3+1;
            Console.WriteLine(" \nincremento:{0}", dato3);
            Console.WriteLine(" \ndecremento:{0}", dato4);
            dato5 += 4; // dato5=dato5+4
            dato3 -= 5; // dato3=dato3-5
            dato5 *= dato3;// dato5=dato5*dato3
            dato6 /= dato3; // dato6=dato6/dato3
            float dato7 = 4 * 3 / 2;
           Console.WriteLine (dato7);
             float dato8 = 4f * (3f / 2f);
            Console.WriteLine(dato8);
            float dato9 = 4 * 6 +  (3f / 2f);
            Console.WriteLine(dato9);
            //operadores Logicos
            Console.WriteLine("TABLA DE VERDAD DE LA CONJUNCION");
            Console.WriteLine("V Y V="+ (true && true));
            Console.WriteLine("V Y F=" + (true && false));
            Console.WriteLine("FY V="+ (false &&true));
            Console.WriteLine("FY F=" + (false && false));

        }
    }
}

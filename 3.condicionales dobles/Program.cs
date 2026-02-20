using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.condicionales_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "";
            float sueldo = 0.0f;
            Console.WriteLine("ingrese el nombre del usuario");
            nombre = Console.ReadLine(); // lo que llega desde la consola, es de tipo string
            Console.WriteLine("ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"la persona {nombre}, debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("persona exenta de impuestos");
            }*/

            float numero1 = 0f;
            float numero2 = 0f;
       
            Console.WriteLine("ingrese el numero 1 ");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            numero2 = float.Parse(Console.ReadLine());
            float suma = numero1 + numero2;
            float diferencia = numero1 - numero2;
            float multiplicacion = numero1 * numero2;
            float division = numero1 / numero2;
            if (numero1 > numero2)
            {
                Console.WriteLine("el resultado de la suma es: " + suma + " y el resultado de la resta es " + diferencia);

            }
            else
            {
                Console.WriteLine("el resultado de la multiplicacion es:" + multiplicacion + "y el resultado de la divison es:" + division);
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Don Nacho, un tendero, realiza la venta de 10 productos y necesita calcular el valor total de la venta aplicando el IVA correspondiente a cada uno de ellos según las siguientes condiciones:
            Si el valor del producto es mayor a 10.000, se aplica un 15 % de IVA.
Si el valor del producto es menor o igual a 5.000, se aplica un 19 % de IVA.
El programa debe realizar lo siguiente:
Solicitar por teclado el valor de cada uno de los 10 productos.
Calcular el subtotal de cada producto, teniendo en cuenta el valor ingresado más el IVA correspondiente.
Sumar los subtotales de los 10 productos.
Mostrar en pantalla el valor total de la venta.*/

            int productos = 1; //contador
            float Vproducto = 0;
            float subproducto = 0;
            int iva1 = 15;
            int iva2 = 19;
            float VTproductos = 0;

            for (productos = 1; productos <= 10; productos++)
            {
                Console.WriteLine("ingrese el valor del producto  ");
                Vproducto = float.Parse(Console.ReadLine());
                if (Vproducto > 10000)
                {
                    subproducto = (Vproducto * iva1 / 100) + Vproducto;
                    VTproductos += subproducto;

                }
                else
                {
                    if (5000 >= Vproducto)
                    {
                        subproducto = (Vproducto * iva2 / 100) + Vproducto;
                        VTproductos += subproducto;


                    }
                    if (10000 >= Vproducto && Vproducto > 5000)
                    {
                        subproducto = Vproducto;
                        VTproductos += subproducto;
                    }
                    
                }
                



            }
            Console.WriteLine($"el valor total de la venta es {VTproductos}");


        }

    }
}


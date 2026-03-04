using System;

namespace _7.condicionalesmultiplesoperador_terciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string diasemana = "";
            float subtotal = 0f;
            float descuento=0f;

            Console.WriteLine("ingrese el monto de la compra");
            subtotal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese dia de la semana");
            diasemana = Console.ReadLine();

            switch (diasemana)
            {
                case "lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"hoy es lunes, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");

                  break;
                case "martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"hoy es martes, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");
                    break;
                case "miercoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"hoy es miercoles, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");

                    break;
                case "jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"hoy es jueves, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");
                    break;
                case "viernes":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"hoy es viernes, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");
                    break;
                case "sabado":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"hoy es sabado, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");
                    break;
                case "domingo":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"hoy es domingo, el descuento es de {descuento} el total a pagar es {subtotal - descuento}");
                    break;
                default:
                    break;
            }*/
            string operacion = "";
            float num1 = 0f;
            float num2 = 0f;
            float resultado = 0f;
            Console.WriteLine("ingrese una operacion entre suma , resta ,division y multiplicacion");
            operacion =Console.ReadLine();
            switch (operacion)
            {
                case "suma":
                    Console.WriteLine("ingrese el numero 1 ");
                     num1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("ingrese el numero 2 ");
                     num2 = Convert.ToSingle(Console.ReadLine());
                    resultado = num1+   num2;
                    Console.WriteLine($"el resultado es {resultado}");
                    break;
                case "resta":
                    Console.WriteLine("ingrese el numero 1 ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("ingrese el numero 2 ");
                    num2 = Convert.ToSingle(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine($"el resultado es {resultado}");
                    break;
                        case "division":
                    Console.WriteLine("ingrese el numero 1 ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("ingrese el numero 2 ");
                    num2 = Convert.ToSingle(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine($"el resultado es {resultado}");
                    break;
                case "multiplicacion":
                    Console.WriteLine("ingrese el numero 1 ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("ingrese el numero 2 ");
                    num2 = Convert.ToSingle(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine($"el resultado es {resultado}");
                    break;
                default:
                    break;
            }
        }
    }
}

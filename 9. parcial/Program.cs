using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            float califact = 0f;
            uint añosempresa = 0;
            float califant = 0f;
            float promcalif = 0f;
            float Paumento = 0f;
            float Vaumento = 0f;
            int sueldo = 2500000;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese sus años en la empresa");
            añosempresa = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("ingrese su Calificación del año actual");
            califact = float.Parse(Console.ReadLine());
            if (califact != 0 && califact != 0.4 && califact != 0.6 && califact != 1)
            {
                Console.WriteLine("error, calificacion actual, valor ingresado: " + califact);
                return;
            }
            Console.WriteLine("ingrese su Calificación del año pasado");
            califant = float.Parse(Console.ReadLine());
            if (califant != 0 && califant != 0.4 && califant != 0.6 && califant != 1)
            {
                Console.WriteLine("error, calificacion anterior, valor ingresado: " + califant);
                return;
            }
            else
            {
                promcalif = ((califant + califact) / 2);
                if (añosempresa < 1)
                {
                    Paumento = 0;
                    Vaumento = (sueldo * (Paumento / 100));
                    Console.WriteLine($"su perfil es {nombre} ");
                    Console.WriteLine($"su promedio es {promcalif}");
                    Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                    Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                }
                else
                {
                    if (añosempresa > 5)
                    {
                        Paumento = 30;
                        Vaumento = (sueldo * (Paumento / 100));
                        Console.WriteLine($"su perfil es {nombre} ");
                        Console.WriteLine($"su promedio es {promcalif}");
                        Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                        Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                    }

                   
                }

            }
          

        }



        
    }
}



/*namespace Simulacionparcial1

{
    //    Desarrollar un programa en C# que determine el porcentaje de aumento salarial de un empleado según su evaluación anual y años trabajados. (70%)
    //Requerimientos
    //Ingreso de datos por el usuario:
    //Nombre del empleado
    //Número de años trabajados en la empresa (número entero positivo)
    //Calificación del año actual (0.0, 0.4, 0.6 o 1.0)
    //Calificación del año anterior (0.0, 0.4, 0.6 o 1.0)
    //Validación de calificaciones:
    //Si la calificación actual o anterior no corresponde a los valores permitidos, mostrar:
    //Error: calificación inválida. El programa terminará.
    //y finalizar el programa.
    //Cálculo del promedio:
    //promedioCalificación = (calificaciónActual + calificaciónAnterior) / 2
    //Determinación del porcentaje de aumento salarial:

    //
    //Años trabajados
    //Promedio calificación
    //% Aumento
    //< 1
    //-
    //0%
    //> 5
    //-
    //30%
    //0 < años ≤ 5
    //0 ≤ promedio < 0.4
    //5%
    //0 < años ≤ 5
    //0.4 ≤ promedio < 0.6
    //10%
    //0 < años ≤ 5
    //0.6 ≤ promedio ≤ 1.0
    //20%
    //Sueldo base:
    //Todos los empleados tienen un sueldo base fijo de $2.500.000.
    //Valor del aumento:
    //valorAumento = sueldoBase × (porcentajeAumento / 100)
    //Salida del programa:
    //Mostrar en pantalla:
    //Nombre del empleado
    //Promedio de calificación
    //Porcentaje de aumento aplicado
    //Valor del aumento en pesos

    //Prueba de escritorio y casos de prueba (30%)
    //Crear al menos 3 casos por rango de aumento.



    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            float califact = 0f;
            uint añosempresa = 0;
            float califant = 0f;
            float promcalif = 0f;
            float Paumento = 0f;
            float Vaumento = 0f;
            int sueldo = 2500000;

            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese sus años en la empresa");
            añosempresa = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("ingrese su Calificación del año actual");
            califact = float.Parse(Console.ReadLine());
            if (califact != 0 && califact != 0.4 && califact != 0.6 && califact != 1)
            {
                Console.WriteLine("error, calificacion actual, valor ingresado: " + califact);
                return;
            }
            Console.WriteLine("ingrese su Calificación del año pasado");
            califant = float.Parse(Console.ReadLine());
            if (califant != 0 && califant != 0.4 && califant != 0.6 && califant != 1)
            {
                Console.WriteLine("error, calificacion anterior, valor ingresado: " + califant);
                return;
            }


            else
            {
                promcalif = ((califant + califact) / 2);
                if (añosempresa < 1)
                {
                    Paumento = 0;
                    Vaumento = (sueldo * (Paumento / 100));
                    Console.WriteLine($"su perfil es {nombre} ");
                    Console.WriteLine($"su promedio es {promcalif}");
                    Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                    Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                }
                else if (añosempresa > 5)
                {

                    Paumento = 30;
                    Vaumento = (sueldo * (Paumento / 100));
                    Console.WriteLine($"su perfil es {nombre} ");
                    Console.WriteLine($"su promedio es {promcalif}");
                    Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                    Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                }
                else if (añosempresa >= 1 && añosempresa <= 5)
                {  // Ultima condicion que faltaba para evaluar
                    if (promcalif >= 0 && promcalif < 0.4)
                    {
                        Paumento = 5;
                        Vaumento = (sueldo * (Paumento / 100));
                        Console.WriteLine($"su perfil es {nombre} ");
                        Console.WriteLine($"su promedio es {promcalif}");
                        Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                        Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                    }
                    else if (promcalif >= 0.4 && promcalif < 0.6)
                    {
                        Paumento = 10;
                        Vaumento = (sueldo * (Paumento / 100));
                        Console.WriteLine($"su perfil es {nombre} ");
                        Console.WriteLine($"su promedio es {promcalif}");
                        Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                        Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                    }
                    else if (promcalif >= 0.6 && promcalif <= 1.0)
                    {
                        Paumento = 20;
                        Vaumento = (sueldo * (Paumento / 100));
                        Console.WriteLine($"su perfil es {nombre} ");
                        Console.WriteLine($"su promedio es {promcalif}");
                        Console.WriteLine($"su Porcentaje de aumento aplicado es {Paumento}");
                        Console.WriteLine($"su Valor del aumento en pesos es {Vaumento}");
                    }

                }


            }



        }
    }
}*/
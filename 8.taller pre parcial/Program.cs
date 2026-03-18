using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _8.taller_pre_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {




            float x1 = 0;
            float x2 = 0;
            float x3 = 0;
            float y1 = 0;
            float y2 = 0;
            float y3 = 0;
            float dist1 = 0f;
            float dist2 = 0f;
            float dist3 = 0f;
            Console.WriteLine("ingrese coordenada x1");
            x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese coordenada x2");
            x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese coordenada x3");
            x3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese coordenada y1");
            y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese coordenada y2");
            y2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese coordenada y3");
            y3 = Convert.ToSingle(Console.ReadLine());
            var punto1 = (X1: x1, Y1: y1);
            var punto2 = (X2: x2, Y2: y2);
            var punto3 = (X3: x3, Y3: y3);
            Console.WriteLine($"\nEl punto1 guardado es: ({punto1.X1}, {punto1.Y1})");
            Console.WriteLine($"\nEl punto2 guardado es: ({punto2.X2}, {punto2.Y2})");
            Console.WriteLine($"\nEl punto3 guardado es: ({punto3.X3}, {punto3.Y3})");
            dist1 = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(($"la distancia entre el punto 1 y el punto 2 es ({dist1})"));
            dist2 = (float)Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));

            Console.WriteLine(($"la distancia entre el punto 2 y el punto 3 es ({dist2})"));

            dist3 = (float)Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y2, 2));
            float distM = 0;
            Console.WriteLine(($"la distancia entre el punto 3 y el punto 1 es ({dist3})"));
            if (dist1 > dist2 && dist1 > dist3)
            {
               

                    distM = dist1;

                    if ((dist2 + dist3) > distM)
                    {
                        Console.WriteLine("se puede crear un traingulo");
                    }

                }
                ;
            }
            if (dist2 > dist1 && dist2 > dist3)
            {
                

                    distM = dist2;
                    if ((dist1 + dist3) > distM)
                    {
                        Console.WriteLine("se puede crear un traingulo");
                    }


                    if (dist3 > dist1 && dist3 > dist2)
                    {

                            distM = dist3;
                            if ((dist1 + dist2) > distM)
                            {
                                Console.WriteLine("se puede crear un traingulo");
                            }

                        
                    }
                }
            }
            else
            {
                Console.WriteLine("no se puede crear un triangulo");
            }
        }
    }
}   

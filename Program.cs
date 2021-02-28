using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoCorte
{
    class Program
    {
        static void Main(string[] args)
        {
            Volver:
            float Edad = 0, estatura = 0;
            Console.WriteLine("Bienvenido \n¿Que edad tienes? ");
            Edad = float.Parse(Console.ReadLine());

            if (Edad < 10 | Edad >= 18)
            {
                Console.WriteLine("Disculpa, no cumples con la edad permitida para participar en los juegos");
            }
            else
            {
                Console.WriteLine("¿Cual es su estatura? \nIngrese el valor en centimetros");
                estatura = float.Parse(Console.ReadLine());

                if (estatura < 120 | estatura >= 180)
                {
                    Console.WriteLine("Lo siento, no cumples con la estatura permitida");
                }
                else
                {
                    if (estatura >= 120 & estatura <= 160)
                    {
                        Console.WriteLine("Felicidades, Tienes acceso a las siguientes atracciones \n" +
                            " \nEl Gusanito \nCastillo Encantado \nAutos Chocones Mini");
                    }
                    if (estatura >= 161 & estatura <= 180)
                    {
                        Console.WriteLine("Felicidades, Tienes acceso a las siguientes atracciones \n" +
                            " \nMontaña Rusa \nCastillo Embrujado \nAutos Chocones");
                    }

                }

                
            }

            Console.WriteLine("\n¿Otro niño en la fila? \n1 = si \n2 = no");
            string n = Console.ReadLine();
            if ( n == "1") 
            {
                Console.Clear();
                goto Volver; 
                
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Program
    {
        //Práctica 1
        #region
        static void Practica1()
        {
            Console.WriteLine("Introduzca el radio (en cm):");

            int r = int.Parse(Console.ReadLine());

            const double PI = 3.14;

            Console.WriteLine($"El área del círculo de radio {r} cm es {PI * Math.Pow(r, 2)} cm");
        }
        #endregion

        //Práctica 2
        #region
        static void Practica2()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("Introduce tu edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= PUEDE_CONDUCIR)
            {
                Console.WriteLine("¿Tienes carnet de conducir?");
                string respuesta = Console.ReadLine().ToUpper();

                if (string.Equals(respuesta, TIENE_CARNET))
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("No puedes conducir");
                }
            }
            else
            {
                Console.WriteLine("No eres mayor de edad para poder conducir");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            //Practica1();
            Practica2();
        }
    }

    
}


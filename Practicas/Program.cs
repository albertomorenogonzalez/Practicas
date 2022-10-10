using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el radio (en cm):");

            int r = int.Parse(Console.ReadLine());

            const double PI = 3.14;

            Console.WriteLine($"El área del círculo de radio {r} cm es {PI * Math.Pow(r, 2)} cm");
        }
    }
}


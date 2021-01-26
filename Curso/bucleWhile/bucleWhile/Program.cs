using System;

namespace bucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas ingresar al bucle?");
            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas dentro del bucle while");
                Console.WriteLine("Ingresa tu nombre, por favor.");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Saldras del buble {nombre} si escribes la palabra 'no'");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("Haz salido del bucle");
        }
    }
}

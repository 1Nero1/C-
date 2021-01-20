using System;

namespace condicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Evaluaremos si eres mayor de edad");
            Console.WriteLine("Por favor ingresa tú edad:");
            edad = int.Parse(Console.ReadLine());

            if (edad >=18)
            {
                Console.WriteLine("Felicidades eres mayor de edad!");
            }
            else
            {
                Console.WriteLine("Aun eres menor de edad.");
            }

        }
    }
}

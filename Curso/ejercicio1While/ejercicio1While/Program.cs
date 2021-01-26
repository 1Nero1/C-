using System;

namespace ejercicio1While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que de un número al azar del 0-100, y que nos indique si
            // estamos sercas o no del numero y una vez localizado el número nos indique las 
            // n cantidad de veces que lo intentamos.

            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            Console.WriteLine(numeroAleatorio);
        }
    }
}

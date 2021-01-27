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

            // Forma de obtener un numero aleatorio
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            Console.WriteLine(numeroAleatorio);

            //Practica hecha por mi
            miPractica();
        }
        static void miPractica()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            
            int respuesta;
            int contador = 0;

            Console.WriteLine("Ingresa un número entre 0 y 100");
            respuesta = Int32.Parse(Console.ReadLine());

            while (respuesta != numeroAleatorio)
            {
                contador++;

                if (respuesta > numeroAleatorio)
                {
                    Console.WriteLine("Te paste!");
                    Console.WriteLine("Escribe nuevamente un número");
                    respuesta = Int32.Parse(Console.ReadLine());
                }
                if (respuesta < numeroAleatorio)
                {
                    Console.WriteLine("Te falta!");
                    Console.WriteLine("Escribe nuevamente un número ");
                    respuesta = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Felicidades encontraste el numero");
            Console.WriteLine(numeroAleatorio);
            Console.WriteLine($"Lo intentaste: {contador} veces");
        }
    }
}

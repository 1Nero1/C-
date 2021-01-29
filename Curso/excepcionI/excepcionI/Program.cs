using System;

namespace excepcionI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                // "try...catch" es el BLOQUE QUE CACHA LAS EXCEPCIONES...
                // 
                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex) // se coloca "e" de ERROR o "ex" de EXCEPCIÓN
                {
                    Console.WriteLine("No haz introducido en valor númerico valido.");
                    Console.WriteLine("Se tomara como valor númerico introducido el 0");
                    respuesta = 0;
                }

                if (respuesta > aleatorio) Console.WriteLine("El número es más bajo.");
                if (respuesta < aleatorio) Console.WriteLine("El número es más alto.");
                intentos++;
            } while (respuesta != aleatorio);

            Console.WriteLine($"Correcto! lo intentastes {intentos} veces.");
        }
    }
}

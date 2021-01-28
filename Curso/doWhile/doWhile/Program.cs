using System;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de Do-While
            // El Do-While es similar que el While solo que aqui en ek Do-While se
            // correra una vez el codigo aunque no se cumpla la condición.
            // Ejemplo:
            int numero = 11;
            do
            {
                Console.WriteLine("Impreción " + numero);
                numero++;
            } while (numero <= 10); // No se cumple la condición pero aun asi
            // correra una vez

            // Ejemplo de donde se puede usar
            Ejemplo();
        }
        static void Ejemplo()
        {
            // Por lo regular el "Do-while" nos irve para simplificar código
            // aunque este ejemplo es tiene muchas lineas de código, hay ocaciones
            // en las que el "Do-while" nos ayudara a tener menos código.
            Random numero = new Random();

            int aleatorio = numero.Next(0,100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                respuesta= int.Parse(Console.ReadLine());
                if (respuesta>aleatorio) Console.WriteLine("El número es más bajo.");
                if (respuesta < aleatorio) Console.WriteLine("El número es más alto.");
                intentos++;
            } while (respuesta!=aleatorio);

            Console.WriteLine($"Correcto! lo intentastes {intentos} veces.");
        }
    }
}

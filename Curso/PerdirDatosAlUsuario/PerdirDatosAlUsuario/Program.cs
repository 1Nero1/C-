using System;

namespace PerdirDatosAlUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Ingrese su Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Su nombre es {nombre} y su edad es de {edad}");
        }
    }
}

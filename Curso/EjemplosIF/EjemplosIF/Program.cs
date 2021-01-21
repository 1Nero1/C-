using System;

namespace EjemplosIF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muestra de if sin corchetes
            
            // comenta el segundo y luego el primero mentalo y descomenta el segundo. 
            Ejemplo1();
            Ejemplo2();
        }
        static void Ejemplo1()
        {
            Console.WriteLine("Hace frio?");
            bool frio = true;
            // Como solo es una linea de código tanto para "IF" como "ELSE" pueden no llevar {}
            // corchertes y pueden ir en la misma liena
            // ES BUENA PRACTICA CUANDO ES SÓLO UNA LINEA COLOCARLO TODO EN UNA LINEA COMO SE
            // MUESTA EN EL EJEMPLO;
            if (frio) Console.WriteLine("LLevate sueter!");
            else Console.WriteLine("No, puedes salir tranquilo");
        }

        static void Ejemplo2()
        {
            // Pidienso datos al usuario
            Console.WriteLine("Introduce tu edad:");
            int edad = Int32.Parse(Console.ReadLine()); // Pidiendo datos
            
            Console.WriteLine("Sabes conducir? (si/no)");
            string conducir = Console.ReadLine();

            if (edad>=18 && conducir=="si") Console.WriteLine("Felicidades!");
            else if(edad>=18 && conducir=="no") Console.WriteLine("Debes aprender a conducir.");
            else Console.WriteLine("Tienes que tener 18 para aprender a conducir");
        }
    }
}

using System;

namespace InicioConCshart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declaracion de variables numericas
            int val = 1;
            //En C# se necesita declarar con esa letra que se especifica (como se muestra) la final de nuestro numero o declaracion.  
            double val2 = 2.5d;
            decimal val3 = 5.5m;
            float val4 = 10.0f;

            Console.WriteLine(val);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
            Console.WriteLine(val4);

            //Formas de concatenar
            Console.WriteLine("Dos formas de imprimir:");
            int edad = 19;
            Console.WriteLine("Primir Forma");
            Console.WriteLine("Tienes una edad de " + edad + " años" );
            Console.WriteLine("Segunda Forma");
            Console.WriteLine($"Tienes una edad de {edad} años");

            //Operadores aritmeticos
            Console.WriteLine("Operadores aritmeticos");
            //Suma
            Console.WriteLine("Suma de 5+5");
            Console.WriteLine(5 + 5);
            //Resta
            Console.WriteLine("Resta de 15+8");
            Console.WriteLine(15-8);
            //Multiplicacion
            Console.WriteLine("Multiplicación de 5*8");
            Console.WriteLine(5*8);
            //Divicion
            Console.WriteLine("Divición de 5/2");
            Console.WriteLine(5 / 2);
            Console.WriteLine("Divición de 5.0/2.0 CON DECIMALES " );
            Console.WriteLine(5.0 / 2.0);
            Console.WriteLine("Divición de 5.0/2 CON UNA DECIMAL ");
            Console.WriteLine(5.0 / 2);
            //Residuo
            Console.WriteLine("Residuo de la divicion de 9/3");
            Console.WriteLine(9%3);
            Console.WriteLine("Residuo de la divicion de 9/4");
            Console.WriteLine(9%4);
        }
    }
}

using System;

namespace sobrecardaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visual Studio ayuda a saber que tipo de método de la sobrecarga de métodos vas a
            // utilizar. Ejemplo;

            Console.WriteLine("llamando al primer método");
            Console.WriteLine(Suma(7, 8));

            Console.WriteLine("Llamando al segundo método");
            Console.WriteLine(Suma(7.5, 6.9));
            Console.WriteLine(Suma(8.9, 8.1));

            Console.WriteLine("Llamando al tercer método");
            Console.WriteLine(Suma(7, 8, 4));
            
        }

        // Aqui es donde se crea la sobrecarga de métodos
        static int Suma(int operador1, int operador2) => operador1 + operador2;

        static double Suma(double numero1, double numero2) => numero1 + numero2;

        static int Suma(int numero1, int numero2, int numero3) => numero1 + numero2 + numero3;
        
        // La sobrecarga de métodos se cuando se crean varios métodos con el mismo nombre, pero
        // tiene diferentes tipos o parametros como se ve en este ejemplo.
    }
}

using System;

namespace parametrosOpcioneales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este es un ejemplo de parametros opcionales
            int val1 = 5;
            double val2 = 5.8;
            double val3 = 7.2;

            Console.WriteLine("La suma es de 5+5.8+7.2");
            Console.WriteLine(suma(val1,val2));
            // aqui solo mandamos a sumar los valores que queremos
            Console.WriteLine(suma(val1,val2,val3));
        }
        static double suma(int numero1, double numero2,double numero3=0)
            // aqui no nos mostrara error ya que el tercer valor es opcional 
            // Al colocar una variable definida como en este ejemplo. a esto se le llama
            // parametro opcional
        {
            return numero1 + numero2 + numero3;
            // aqui debemos de sumar todos los parametros...
        }
    }
}

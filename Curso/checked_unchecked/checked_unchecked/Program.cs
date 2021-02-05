using System;

namespace checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo del uso de Unchecked
            EjemploSinchecked();

            EjemploConChecked();
        }

        static void EjemploSinchecked()
        {
            // Ejemplo sin un checked 
            int numero = int.MaxValue;
            Console.WriteLine("Este es el número maximo de un INT "+numero);

            int suma = numero + 15;

            Console.WriteLine("sumamos el maximo valor +15 "+suma);

            // como vemos nos dio un número negativo ya que C# sabe que esta mal el 
            // resultado pero para no dejar caer el programa, manda un resultado
            // erroneo y continua
            Console.WriteLine("más código...");
        }
        static void EjemploConChecked()
        {
            int numero = int.MaxValue;
            Console.WriteLine("Este es el número maximo de un INT " + numero);

            checked
            {
                int suma = numero + 15;
                Console.WriteLine("sumamos el maximo valor +15 " + suma);
                // Como vemos aqui, Si, se detiene el programa y no continua con las 
                // demas lineas de código. ya que aqui si esta verificando (estrictamente)
                // las lineas de código...
            }

            Console.WriteLine("Más código...");
        }
    }
}

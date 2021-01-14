using System;

namespace Practicando_Metodos
{
    class Program
    {
        static void Main(string [] args)
        {
            // Llamando un método
            primerMetodoCreado();

            // Llamando un método con paso de parámetros
            metodoConParametros(9,7);

            Console.WriteLine("Este es el mensaje 2");
            Console.WriteLine("Mensaje desde el método 'Main'!");

            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++Métodos con return+++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            // Llamando al m;etodo que regresa valores 
            Console.WriteLine(metodoConReturn(15,9));

            Console.WriteLine("Esto es una divición (8/2)");
            Console.WriteLine(divicionConEnteros(8,2));
            
            Console.WriteLine("Esto es una divición con decimal el cual saldra erroneo (9/2)");
            // Recuerda que en un metodo que devuelve (return) debemos especificra lo que queremos
            // que regrese, en este caso queremos que nos regrese una divicion con decimales, pero
            // no regresara las decimales ya que tenemos nuestro método con enteros (INT)
            Console.WriteLine(divicionConEnteros(9,2));

            Console.WriteLine("Esta es una divición sin errores (9/2)");
            Console.WriteLine(divicionConDecimal(9,2));

            // Método de flecha
            Console.WriteLine("Multiplicacion (7*8)");
            Console.WriteLine(multiplicacionConArrow(7,8));
        }
        // Creando método sin parametros
        static void primerMetodoCreado()
        {
            Console.WriteLine("Este es el mensaje 1");
            Console.WriteLine("Mensaje desde el método 'primerMetodoCreado'!");
        }

        // En este método realizaremos una suma
        static void metodoConParametros(int num1 , int num2)
        { // Como se va hacer una suma tiene una sintaxis a utilizar

            // De esta forma nos concatenara todo 
            Console.WriteLine("La suma es: "+num1+num2);

            // Primer forma Correcta
            Console.WriteLine("La suma es: " + (num1 + num2));

            // Segunda forma Correcta
            Console.WriteLine($"La suma es: {num1+num2}");
        }

        // Método que regresa valores
        static int metodoConReturn(int num1, int num2)
        {
            return num1 + num2;
        }

        // Este método realiza una diviciín en enteros el cual no tendra error
        static int divicionConEnteros(int num1, int num2)
        {
            return num1 / num2;
        }

        // Este método realiza una divición con un entero y un decimal el cual tendra error
        static double divicionConDecimal(double num1, int num2)
        {
            // Recuerda que no necesariamente tendremos que colocar todos los tipos de datos 
            // como queremos que regren (solo en estos casos). Aqui podemos ingresar un double 
            // y un int PERO si debemos colocar primero el valor que queremos que mos regrese.
            // En este caso el DOUBLE.
            return num1 / num2;
        }

        // Arrow (arrow function "JavaScript")
        // Este método solo puede ser usado cuando se tiene solo una linea de código dentro del método
        static int multiplicacionConArrow(int num1, int num2) => num1 * num2;
    }
}

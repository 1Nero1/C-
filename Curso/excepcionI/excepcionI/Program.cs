using System;

namespace excepcionI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excepciones
            // Para capturar excepciones se utiliza el bloque "TRY...CHATCH"

            // Muestra de una excepcion:
            /*EjemploExcepcion1();*/

            // Muestra de dos Excepciones:
            /*EjemploExcepcion2();*/

            // Muestra de una Excepcion Generica
            /*EjemploExcepcion3();*/

            // Conflictos en el uso de varios "catch"
            /*EjemploExcepcion4();*/

            // Captura de excepciones con filtros
            EjemploExcepcion5();
        }
        static void EjemploExcepcion1()
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                // "try...catch" es el BLOQUE QUE CACHA LAS EXCEPCIONES...

                // Para saber que tipo de excepcion vamos a ingresar o colocar va 
                // depender del error o formato de excion que nos brinde C#...

                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                    // En este caso se usara una excepcion "FormatException"
                    // ya que no estamos agregando un valor numerico:
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

            Console.WriteLine("A partir de esta linea. El código continua...");
        }

        static void EjemploExcepcion2()
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                // "try...catch" es el BLOQUE QUE CACHA LAS EXCEPCIONES...

                // Para saber que tipo de excepcion vamos a ingresar o colocar va 
                // depender del error o formato de excion que nos brinde C#...

                // Cuando se requiere mas de una excepción se coloca otro catch:
                // esto quiere decir que casi es similir al IF...
                // Ejemplo;
                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                // En este caso se usara una excepcion "FormatException"
                // ya que no estamos agregando un valor numerico:
                catch (FormatException ex) // se coloca "e" de ERROR o "ex" de EXCEPCIÓN
                {
                    Console.WriteLine("No haz introducido en valor númerico invalido.");
                    Console.WriteLine("Se tomara como valor númerico introducido el 0");
                    respuesta = 0;
                }
                // En este caso se usara una excepcion "OverflowException"
                // ya que estamos agregando un valor demaciado alto a la
                // variable indicada...
                catch (OverflowException ex)
                {
                    Console.WriteLine("Haz introducido un valor muy alto.");
                    Console.WriteLine("Se tomara como valor númerico el 0");
                    respuesta = 0;
                }

                if (respuesta > aleatorio) Console.WriteLine("El número es más bajo.");
                if (respuesta < aleatorio) Console.WriteLine("El número es más alto.");
                intentos++;
            } while (respuesta != aleatorio);

            Console.WriteLine($"Correcto! lo intentastes {intentos} veces.");

            Console.WriteLine("A partir de esta linea. El código continua...");
        }
        static void EjemploExcepcion3()
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                // "try...catch" es el BLOQUE QUE CACHA LAS EXCEPCIONES...

                // La EXCEPCION GENERICA O GENERAL es el padre de todas las exceciones,
                // ya que nos ayuda a que el código sea menos (que no haya tantos catch).

                // No es muy recomendable ya que en la hora de crear código se necesita
                // tener la maxima exactitud posible.( En este caso para saber los errores)
                
                // En C# tiene la opcion de colocar (Exception) o no. 
                // No es recomendable ya que no sabremos qeu cacha o no podriamos leerlo
                // si no lo tuviera y fuera un código ageno al nuestro.
                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                // Excepcion Generica o General
                catch (Exception ex) // se coloca "e" de ERROR o "ex" de EXCEPCIÓN
                {
                    Console.WriteLine("Error");
                    // La "ex" tiene muchas propiedades y en este caso la usamos para que 
                    // nos indique por mensaje, que tipo de excepcion se trata?
                    // La indicacion sera en ingles
                    Console.WriteLine(ex.Message);

                    respuesta = 0;
                }

                if (respuesta > aleatorio) Console.WriteLine("El número es más bajo.");
                if (respuesta < aleatorio) Console.WriteLine("El número es más alto.");
                intentos++;
            } while (respuesta != aleatorio);

            Console.WriteLine($"Correcto! lo intentastes {intentos} veces.");

            Console.WriteLine("A partir de esta linea. El código continua...");
        }

        static void EjemploExcepcion4()
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                // BUENA ESTRUCTURA DE MUCHOS CATCH
                    // Para tener un buen orden se deben colocar los chatch de más especifico
                    // a menos especifico ya que si se coloca de manera contraria marcara error.

                // CATCH ESPECIFICO
                catch (FormatException ex)
                {
                    Console.WriteLine("Ingresaste letras en lugar de números.");
                    Console.WriteLine("Se tomara como numero ingresado el 0");
                    respuesta = 0;
                }

                // CATCH GENERICO
                catch (Exception ex) // se coloca "e" de ERROR o "ex" de EXCEPCIÓN
                {
                    Console.WriteLine("Error");
                    Console.WriteLine(ex.Message);
                    respuesta = 0;
                }

                if (respuesta > aleatorio) Console.WriteLine("El número es más bajo.");
                if (respuesta < aleatorio) Console.WriteLine("El número es más alto.");
                intentos++;
            } while (respuesta != aleatorio);

            Console.WriteLine($"Correcto! lo intentastes {intentos} veces.");

            Console.WriteLine("A partir de esta linea. El código continua...");
        }

        // Captura de Excepciones con filtros
        static void EjemploExcepcion5()
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int respuesta;
            int intentos = 0;

            Console.WriteLine("Escribe un número entre 0 y 100");
            do
            {
                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                //Excepciones con filtros
                    // Para crear una excepcion con filtro se coloca la palabra "when()"
                    // adelante de esta se escribe la excepcion que se desea excluir
                    // para ello la variable colocada en excepction (e o ex) a conticuacion
                    // . y la propiedad getType()
                    // y el tipo de excepcion que escluiremos 
                    // EJEMPLO;

                // Excepcion Generica o General
                catch (Exception ex) when(ex.GetType()!=typeof(FormatException))
                // Lo que indicamos es que capture todas las excepciones menos la 
                // "FormatException" ya que esa la colocaremos en otro catch
                {
                    Console.WriteLine("Error");
                    Console.WriteLine(ex.Message);

                    respuesta = 0;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Haz introducido texto.");
                    respuesta = 0;
                }

                if (respuesta > aleatorio) Console.WriteLine("El número es más bajo.");
                if (respuesta < aleatorio) Console.WriteLine("El número es más alto.");
                intentos++;
            } while (respuesta != aleatorio);

            Console.WriteLine($"Correcto! lo intentastes {intentos} veces.");

            Console.WriteLine("A partir de esta linea. El código continua...");
        }
    }
}

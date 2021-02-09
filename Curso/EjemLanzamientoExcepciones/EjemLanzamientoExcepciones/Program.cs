using System;

namespace EjemLanzamientoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero del Mes");
            int respuesta = int.Parse(Console.ReadLine());

            // Enviando respuesta al metodo y resiviendo respuesta

            // Ejemplo1
            //Console.WriteLine(Meses(respuesta));

            // Ejemplo2
            // En este ejemplo se muestra una excepcion la cual es de la biblioteca .net
            // pero esto a la vez parara el programa y no podra continuar...
            //Console.WriteLine(Messes(respuesta));

            // Para evitar este tipo de reacciones se debe de meter en un "try...chacked"
            // Para que elcódigo no se ropa y pueda continuar...
            try
            {
                Console.WriteLine(Messes(respuesta));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje del error: "+ex.Message);
            }

            Console.WriteLine("Aqui va el resto del código que va despues del mes...");
        }
        // Crear un metodo que contenga los meses
        public static string Meses(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febreso";
                
                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "julio";

                case 8:
                    return "Agostos";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default: // Recuerda: que esta parte va todos los errores que se
                         // contemplan en el desarrollo: como ejemplo el primer return...
                    return "Mes erroneo";

            }
        }

        public static string Messes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febreso";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "julio";

                case 8:
                    return "Agostos";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default:
                    // Ingresando una excepcion de la biblioteca .net framework
                    // https://docs.microsoft.com/es-es/dotnet/api/system?view=net-5.0
                    // Para agregar este tipo de excipnes se utiliza el comando "THROW"

                    throw new ArgumentOutOfRangeException();

            }
        }
    }
}

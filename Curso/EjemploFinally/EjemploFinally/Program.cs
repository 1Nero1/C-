using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo=null;

            try
            {
                string lineas; // Variable que representa las lineas del archivo
                int contador = 0; // Varible que representala el numero de linea en la que ira avanzando

                // Ruta Buena
                string ruta = @"C:\Users\Pikachu\Desktop\Mis Practicas\C#\Curso\Recursos\ArchFinally.txt";

                // Ruta Mala
                //string ruta = @"C:\Users\Pikachu\Desktop\Mis Practicas\C#\Curso\Recursos\noruta.txt";
                
                archivo = new System.IO.StreamReader(ruta);
                while ((lineas=archivo.ReadLine())!= null)
                {
                    Console.WriteLine(lineas);
                    contador++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Mensaje del error: "+ex.Message);
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexión con el archivo cerrado.");

                // NOTA: Con este bloque (finally) obligas a que siempre se regrese a leer el
                // código , haciendo referencia de que si dentro el "try" existe una linea que
                // lleve a otro lado con el bloque "finally" te aseguras que regrese a validar 
                // que todo este bien.
            }
        }
    }
}

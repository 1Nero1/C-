using System;

namespace checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // Los checked y uncheck, solo son usados para primitivos INT y LONG

            // Ejemplo del uso de Unchecked
            /*EjemploSinchecked();*/

            /*EjemploConChecked();*/
            /*EjemploDosConChecked();*/

            // Para evitar estar poniendo y colocando CHECK'S Visual Studio tiene
            // una configuracion para que lo haga sin colocar los CHECK'S.

            // Para habilitarla devemos ir a la parte derecha en ESPLORADOR DE
            // SOLUCIONES  buscar el proyecto con el cual trabajaremos y dar 
            // CLICK DERECHO ir a PROPIEDADES buscar en la parte izquieda COMPILACIÓN
            // y bajar hasta encontrar AVANZADO... y marcar la casilla de COMPROBAR EL
            // DESBORDAMIENTO ARITMETICO, unavez realizado eso ACEPTAMOS y guardamos 
            // CRTL+S y quedara listo...


            // UNCHECKED
            // Los unchecked se utilizan cuando queremos autorizar o pasar por alto 
            // ciertos desbordamientos, y cuando tenemos habilitada la funcion de 
            // Comprobar Desbordamiento Aritmetico...

            // Para ver ete ejemplo recuerda tener habilitada la funcion de  Visual Studio
            EjemploUnchecked();
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

        static void EjemploDosConChecked()
        {
            int numero = int.MaxValue;
            Console.WriteLine("Este es el número maximo de un INT " + numero);

            int suma = checked(numero + 15);
            // Nos mandara error como debe de ser...

            Console.WriteLine("sumamos el maximo valor +15 " + suma);
            Console.WriteLine("Y más código...");
        }

        static void EjemploUnchecked()
        {
            int numero = int.MaxValue;
            Console.WriteLine("El número maximo de INT es "+numero);

            // UNCHECKED: se puede aplicar como "checked" con los corchetes o en una linea
            // en este caso usaremos una sola linea.

            int suma = unchecked(numero + 20);
            Console.WriteLine("El resultado anterior se sumo + 20 " +suma);
            Console.WriteLine("Aqui hay mucho más código...");
        }
    }
}

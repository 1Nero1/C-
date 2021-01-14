using System;

namespace ambitoMetodo
{
    /*======================
    ===Inicio de la clase===
    ======================*/

    // Ámbito o alcance
    // El ambito o alcance se reprecenta por los corchetes "{}" ya que estos indican donde empieza
    // y en donde termina,es to es valido para todas las funciones pero se aplica solo para "Métodos,
    // clases" ya que en estas se hace referiencia de que las variables soll se pueden usar en ese
    // "Ámbito" ya sea de la clase o método.
    class Program
    {
    
        // ===Inicio del Método principal===
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        // ===Fin del Método Principal


        /* //comentar o decomentar para ver la primera forma del ámbito
        
        // ===Inicio del Segundo Método===
        void segundoMetodo()
        { // Inicio del ámbito o alcance
            int numero1 = 9;
            int numero2 = 9;
        } // Fin del ámbito
        // ===Fin del Segundo Método===
        

        // ===Inicio del Segundo Método===
        void tercerMetodo()
        { // Inicio del ámbito o alcance
            Console.WriteLine("Imprimiendo la suma del primer método en el segundo método.");
            // Me muestra error porque los valores que son iguales a los del primer metodo no puede
            // realizar la suma y no porque no lo llamemos 
            // Sino porque en este metodo "tercerMetodo" no esta dentro de su "Ámbito"
            Console.WriteLine(numero1+numero2);
            // Esto se puede solucionar mandando a llamar al método o bien haciendo las variables 
            // globales o a niver de clase (que esto es más para programacion orientada a objetos).
        } // Fin del ámbito
        // ===Fin del Tercer Método===*/

        /*=================================
        ===Muestra de variables globales===
        =================================*/
        void cuartoMetodo() // ===Inicio del Cuarto Método===
        { // Inicio del ámbito
            Console.WriteLine("Suma de 8+4");
            Console.WriteLine(numeroUno+numeroDos);

        } // Fin del ámbito 
        // ===Fin del Cuarto Método===


        void quintoMetodo() // ===Inicio del Quinto Método===
        { // Inicio del ámbito
            Console.WriteLine("Multiplicación de 8+4");
            Console.WriteLine(numeroUno + numeroDos);

        } // Fin del ámbito 
        // ===Fin del Quinto Método===

        //===Campo de Clase===//
        int numeroUno = 8;
        int numeroDos = 4;

    }// ===Fin de la clase===
}

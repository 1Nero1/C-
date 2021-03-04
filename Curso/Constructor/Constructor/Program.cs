using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //// CONSTRUCTORES 
            // Los contructores tienen como finalidad dar un estado inicial a los objetos

            // Lamando a los Métodos
                // Creando Objetos 
                // Creando Instancia 
            Coche ObjCoche = new Coche(); // Dando un estado inicial a nuestro Primer Objeto

            Coche ObjCoche2 = new Coche(); // Dando un estado inicial a nuestro Segundo Objeto

            //==Podemos Llamar/ ver nuestros datos de nuestros Objetos?==
                //NO, Para ello tenecitamos un método de acceso. Para acceder a los DATOS/
                // PROPIEDADES de una clase se led denomida "MÉTODOS GETTERS"

            Console.WriteLine(ObjCoche.getRuedas());

            Console.WriteLine(ObjCoche.getInfoCoche());

            Console.WriteLine(ObjCoche2.getInfoCoche());
        }
    }

    class Coche
    {
        // Este es el CONSTRUCTOR...
        // El constructor es el que se encarga del estado inicial de nuestra clase (en este caso
        // el comportamiento del coche )
            // * Debe de tener el mismo nombre que la clase
            // * No puede debolver ningun dato
            // * no es VOID

        public Coche() // CONSTRUCTOR
        {
            // Aqui es donde va el estado inicial, su comportamiento, caracteristicas, etc.

            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;

        }

        // Método de acceso get
            // este metodo de acceso solo es usado para acceder a las propiedades de
            // las clases.
        public int getRuedas()
        {
            return ruedas;
        }

        public String getInfoCoche()
        {
            return "Información del coche:\n " + "Redas: "+ ruedas+" Largo: "+largo+" Ancho: "+ancho;
        }

        // Los COMPORTAMIENTOS se determinan con las FUNCIONES/METODOS

        // PROPIEDAD de la clase
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}

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
                // PROPIEDADES de una clase se le denomida "MÉTODOS GETTERS"

            Console.WriteLine(ObjCoche.getRuedas());

            Console.WriteLine(ObjCoche.getInfoCoche());

            Console.WriteLine(ObjCoche2.getInfoCoche());

            Console.WriteLine("Deseas agregar un nuevo valor al ancho y largo del coche? (si/no)");
            string res = Console.ReadLine();

            if (res == "si")
            {
                Console.WriteLine("Ingresa el largo del coche:");
                double largoCoche = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el ancho del coche:");
                double anchoCoche = double.Parse(Console.ReadLine());

                // Llamar al nuevo constructos
                Coche ObjCoche3 = new Coche(largoCoche,anchoCoche);

                Console.WriteLine(ObjCoche3.getInfoCoche());
            }
            
            
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

        //================================================
        // SOBRE CARGA DE CONSTRUCTORES
            // Asi como exiten "sobrecarga de métodos", tambien existen sobrecarga de
            // constructores
            // * Esto se produce cuando la clase tiene más de un constructor
            // * De igual manera que el método, se produce siempre y cuando se requieran ciertos
            // atributos
            
        // Ejemplo: en este caso necesitamos crear un vehiculo con nueva anchura y altura:
        public Coche(double largoCoche,double anchoCoche)
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;
        }


        //================================================

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

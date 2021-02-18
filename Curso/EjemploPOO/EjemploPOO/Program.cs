using System;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcularemos el area de un Circulo.");
            Console.WriteLine("Introduce el area:");
            double area = double.Parse(Console.ReadLine());
            //Console.WriteLine(area);

            // Llamando al Objeto

                //Mi primer Objeto
            Circulo miCirculo = new Circulo(); // esto se le conoce como INSTANCIAR una clase

            // Usando las Propiedades de nuestro Objeto
            Console.WriteLine(miCirculo.calcularArea(area));
            // Si en est parte nos da error puede que este mal el codigo.
            // Pero si no esta mal, puede deberse al nivel de seguridad (Encapsulamiento)

            Console.WriteLine("El resultado de abajo siempre sera lo mismo (5)");
            //Mi Segundo Objeto
            Circulo miSegundoCirculo = new Circulo();
            Console.WriteLine(miSegundoCirculo.calcularArea(5));

            // COMO PODEMOS OBSERVAR
            // MUESTRA CLASE (Circulo) ES LA PLANTILLA 
            // Y MUESTRO METODO (calcularArea) Y PORPIEDAD (pi) SON NUESTROS OBJETOS

            // REMENBER: QUE LOS OBJETOS SE OBTIENEN DE LA PLANTILLA Y LAS PROPIEDADES
            // O LO QUE ESTE DENTRO DE NUESTRA PLANTILLA (CLASE) SERAN SUS PROPIEDADES...

            // MÁS CLARO...
            // MUESTRA PLANTILLA ES MUESTRO CHASIS DE UN COCHE (PARTE BAJA Y LLANTAS)
            // Y NUESTRAS PROPIEDADES SON TODO LO DE ARRIBA (VENTANAS, PUERTAS, COLOR, ETC.)
            // ASI ES COMO TRABAJA LA PROGRAMACIÓN ORIENTADA A OBJETOS

            // ASÍ COMO EN ESTE EJEMPLO TENEMOS DOS OBJETOS ("miCirculo" y "miSegundoCirculo")
            // PERO VIENEN DE LA MISMA CLASE (Circulo)

        }
    }
    // crear una clase, se pueden crear en la parte que deciemos ciempre y cuando este en el
    // area del namespace
    class Circulo //Este es nuestro objeto
    {
        const double pi = 3.1416; // Propiedad de la clase / Campo de clase.

        // le damos el nivel de acceso de PUBLIC para que se pueda usar en otra clase
        public double calcularArea(double radio) // Método de Clase.
        {
            return pi * radio * radio;
        }
    }
}

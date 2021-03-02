using System;

namespace Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulación
            // Noa ayuda a ocultar es estado de la variable u objeto y que solo se podra
            //  modificar dentro del alcance del objeto o método.

            // Llamando al Objeto
            ConvertirDolar conversion = new ConvertirDolar();

            Console.WriteLine("El precio del dolar es:19.18");
            // REMEMBER: Recuerda que el dolar es bolatil 
            Console.WriteLine("El precio es el correcto? (si/no)");
            string res = Console.ReadLine();
            if (res=="no")
            {
                Console.WriteLine("Ingrese el valor adecuado:");
                double val = double.Parse(Console.ReadLine());
                conversion.valor(val); // Aqui estamos Accediento al "Método de acceso." 
            }
 
            Console.WriteLine("Ingresa los dolares a convertir en pesoso: ");
            double pesos = double.Parse(Console.ReadLine());


            Console.WriteLine(conversion.ConversionDolar(pesos)); // Aqui estamos accediendo 
                // a el método u objeto principal..
        }
    }

    // Método con encapsulamiento.
    class ConvertirDolar
    {
        // Los datos, variables, constantes, etc. Siempre se colocara como "private"
        private double dolar = 19.18; 
            // Si necesitamos acceder a estos valores lo haremos a traves de un "metodo de aceeso".

        // Este método es de acceso publico
        public double ConversionDolar(double pesos)
        {
            return pesos * dolar;
        }

        // Método de Acceso
        public double valor(double val)
        {
            // El método de acceso nos ayuda a acceder de una mejor manera a nuestra
            // variable o valor y poder modificarlo y como vemos abajo, tener una mejor 
            // Manera para controlar su valor.
            if (val > 0)
            {
                dolar = val;
            }
            else
            {
                Console.WriteLine("El valor no es permitido");
                Console.WriteLine("Se quedara con el valor: " +dolar);
            }
            return dolar;

        }
    }
}

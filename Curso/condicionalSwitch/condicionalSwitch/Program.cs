using System;

namespace condicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estructura();
            //Ejemplo1();
            //Ejemplo2();
        }
        static void Estructura()
        {
            // Esta es la estructura de un Switch

            int valor = 15; // un valor cualquiera

            // LOS "SWITCH" SOLO PUEDEN COMPARAR "INT", "CHAIR" Y "STRING"
            // PARA USAR LOS DEMAS OPERADORES O VARIABLES SE USA "IF"

            switch ( valor ) // aqui va el valor que vamos a comparar
            {
                case 1: // Aqui va el valor por el cual se compara
                    Console.WriteLine("Lineas de código que se ejecutaran");
                    break; // sentendia con la que se finaliza un case o un break...

                case 15: // Aqui va el valor por el cual se compara
                    Console.WriteLine("Lineas de código que se ejecutaran");
                    break; // sentendia con la que se finaliza un case o un break...

                // Y asi hasta n  cantidad de veces

                default:
                    Console.WriteLine("codigo que se ejecuta si no encuentra datos que esten el un case");
                    break; // tambien en lugar de un "BREAK" puede tener otros valores
                           // similares como "RETURN","THROW"...
            }
        }
        static void Ejemplo1()
        {
            Console.WriteLine("Elige un medio de Transporte (vehiculo, tres, avion)");
            string transporte = Console.ReadLine();

            switch (transporte)
            {
                case "vehiculo":
                    Console.WriteLine("Velocidad media: 100 Km/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad media: 250 Km/h");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad media: 800 Km/h");
                    break;
                default:
                    Console.WriteLine("Transporte no contemplado");
                    break;
            }
        }
        static void Ejemplo2()
        {
            Console.WriteLine("Introduce numero del mes que quieres ver.");
            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Este mes le corresponde a Enero");
                    break;
                case 2:
                    Console.WriteLine("Este mes le corresponde a Febrero");
                    break;
                case 3:
                    Console.WriteLine("Este mes le corresponde a Marzo");
                    break;
                case 4:
                    Console.WriteLine("Este mes le corresponde a Abril");
                    break;
                case 5:
                    Console.WriteLine("Este mes le corresponde a Mayo");
                    break;
                case 6:
                    Console.WriteLine("Este mes le corresponde a Junio");
                    break;
                case 7:
                    Console.WriteLine("Este mes le corresponde a Julio");
                    break;
                case 8:
                    Console.WriteLine("Este mes le corresponde a Augost");
                    break;
                case 9:
                    Console.WriteLine("Este mes le corresponde a Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Este mes le corresponde a Octubre");
                    break;
                case 11:
                    Console.WriteLine("Este mes le corresponde a Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Este mes le corresponde a Diciembre");
                    break;

                default:
                    Console.WriteLine("No existe el mes ingresado...");
                    break;
            }
        }
    }
}

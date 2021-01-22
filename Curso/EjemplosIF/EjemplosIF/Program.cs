using System;

namespace EjemplosIF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muestra de if sin corchetes

            // comenta el segundo y luego el primero mentalo y descomenta el segundo. 
            //Ejemplo1();
            //Ejemplo2();
            //Ejemplo3(); // Segunda solucion al Ejemplo2
            //Ejemplo4(); // Tercera solución al Ejemplo2
            //Ejemplo5();
            Ejemplo6();
        }
        static void Ejemplo1()
        {
            Console.WriteLine("Hace frio?");
            bool frio = true;
            // Como solo es una linea de código tanto para "IF" como "ELSE" pueden no llevar {}
            // corchertes y pueden ir en la misma liena
            // ES BUENA PRACTICA CUANDO ES SÓLO UNA LINEA COLOCARLO TODO EN UNA LINEA COMO SE
            // MUESTA EN EL EJEMPLO;
            if (frio) Console.WriteLine("LLevate sueter!");
            else Console.WriteLine("No, puedes salir tranquilo");
        }

        static void Ejemplo2()
        {
            // Pidienso datos al usuario
            Console.WriteLine("Introduce tu edad:");
            int edad = Int32.Parse(Console.ReadLine()); // Pidiendo datos
            
            Console.WriteLine("Sabes conducir? (si/no)");
            string conducir = Console.ReadLine();

            if (edad>=18 && conducir=="si") Console.WriteLine("Felicidades!");
            else if(edad>=18 && conducir=="no") Console.WriteLine("Debes aprender a conducir.");
            else Console.WriteLine("Tienes que tener 18 para aprender a conducir");
        }

        static void Ejemplo3()
        {
            Console.WriteLine("Escribe tu edad:");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad>=18)
            {
                Console.WriteLine("Tienes carnet (licencia) (si/no)");
                string licencia = Console.ReadLine();

                if (licencia=="Si" || licencia=="si") Console.WriteLine("Felicidades");
                else Console.WriteLine("Debes de aprender a conducir!");
            }
            else Console.WriteLine("Tienes que ser mayor de edad para poder conducir");
        }

        static void Ejemplo4()
        {
            Console.WriteLine("Ingresa tú edad:");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad<18) Console.WriteLine("No puedes conducir vehiculos");
            else
            {
                Console.WriteLine("Tienes carnet?");
                string carnet = Console.ReadLine();

                // String.Compare()
                // Es un método que nos ayuda a comparar el resultado que deciemos
                // El primer valor es el de la variable
                // El segundo es el valor que queremos que tenga o sea valida
                // El tercer valor es el que ignora las caracteristicas,
                    // Ejemplo si, Si,sI,Si, etc.
                int comparar = String.Compare(carnet,"si",true);

                if (comparar == 0) Console.WriteLine("Puedes conducir vehiculos");
                else Console.WriteLine("Lo siento mucho, no puedes conducir vehiculos");
            }
        }

        static void Ejemplo5() // Muestra del Operador "O"
        {
            //Ejemplo Obtener el valor de los tres Parciales
            Console.WriteLine("Ingresa tú primer parcial:");
            double parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tú segundo parcial:");
            double parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tú tercer parcial:");
            double parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1>5 || parcial2>5 || parcial3>5) //Verificar que almenos tenga calificacion en un parcial
            {
                Console.WriteLine("Tu promedio es de:"+(parcial1+parcial2+parcial3)/3);
            }
            else Console.WriteLine("Vuelve en Septiembre.");
        }

        static void Ejemplo6() // Calculando edad (Uso del IF-Else)
        {
            Console.WriteLine("Ingresa tú edad");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad<18)
            {
                Console.WriteLine("Eres un Niño");
            }
            else if (edad<=30)
            {
                Console.WriteLine("Eres un Joven");
            }
            else if(edad <= 60)
            {
                Console.WriteLine("Eres un adulto");
            }
            else 
            {
                Console.WriteLine("Eres una persona Mayor");
            }
            // TODO ESTE EJERCICIO NO PUEDE LLEVAR LOS {} YA QUE SOLO ES UNA LINEA DE 
            // CÓDIGO, PERO SE DEJA PARA QUE SEA MAS FACIL DE LEER.
        }
    }
}

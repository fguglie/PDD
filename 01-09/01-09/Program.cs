using System;

namespace _01_09
{
    class Program
    {
        //Ejercicio 1: 
        //armar un juego para adivinar un numero utilizando una variable random, dar 3 chances al jugador para que acierte, 
        //si acierta salen del bucle y le dan un mensaje y si no aciertan imprimen un mensaje dando el numero secreto

        /*
        static void Main(string[] args)
        {

            //inicializo las variables de los intentos, el número ingresado y el ganador.
            int intentos = 0;
            int numeroIngresado = 0;
            int ganador = 0;

            //Seteo el número limite del juego
            int numeroLimite = 10;
            int cantidadDeIntentos = 5;

            //Instancio un objeto Random y randomizo la variable del número ganador
            Random random = new Random();
            int numeroGanador = random.Next(numeroLimite) + 1;

            Console.WriteLine($"Adivine el numero del 1 al {numeroLimite}!. Tienes {cantidadDeIntentos} intentos");
            while (numeroIngresado != numeroGanador && intentos < cantidadDeIntentos && ganador == 0)
            {
                numeroIngresado = ingresoNumero();
                intentos++;

                if (numeroIngresado == numeroGanador)
                {
                    ganador = 1;
                    Console.WriteLine(ganaste());
                }
                else
                {
                    if (intentos == 5)
                    {
                        Console.WriteLine(perdiste(numeroGanador));
                    }
                    else
                    {
                        Console.WriteLine($"Error. te quedan {cantidadDeIntentos - intentos} intentos");
                    }
                }
            }
        }
        static String ganaste()
        {
            return "Felicitaciones, adivinaste!";
        }

        static String perdiste(int numeroGanador)
        {
            var mensaje = "Perdiste, el número era " + numeroGanador + "!";
            return mensaje;
        }

        static int ingresoNumero()
        {
            int numeroIngresado = int.Parse(Console.ReadLine());
            return numeroIngresado;
        }

    }
    */



        //Ejercicio 2:

        /*armar un programa que le pida al usuario ingresar el año de la fecha de nacimiento y calcular si fue biciesto o no
        encapsular en un metodo el ingreso de datos pasando el texto a mostrarle al usuario
        y en otro metodo el calculo de si es biciesto devolviendo un valor booleano*/

        static void Main(string[] args)
        {

            int añoIngresado = ingresoDeAño("Por favor, ingrese su año de nacimiento ");

            if (esBisiesto(añoIngresado))
            {
                Console.WriteLine("El año de nacimiento es bisiesto");
            }
            else
            {
                Console.WriteLine("El año de nacimiento NO es bisiesto");
            }

        }
        static int ingresoDeAño(string mensaje)
        {
            Console.WriteLine(mensaje);
            string año = Console.ReadLine();
            return int.Parse(año);
        }

        static bool esBisiesto(int año)
        {

            if (año % 4 == 0 && año % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

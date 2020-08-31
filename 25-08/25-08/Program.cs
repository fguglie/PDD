using System;

namespace _25_08
{
    class Program
    {
        static void Main(string[] args)
        {

            //Armar un programa que le pida al usuario que adivine un numero que ustedes prefijaron, si adivina le muestran un mensaje de felicitacion, caso contrario que siga participando
            int intentos = 0;
            int numeroIngresado = 0;
            int ganador = 0;
            int numeroGanador = 5;
            Console.WriteLine("Adivine el numero del 1 al 9!. Tienes 5 intentos");  
            while (numeroIngresado != numeroGanador && intentos <5 && ganador == 0)
            {
                numeroIngresado = int.Parse(Console.ReadLine());
                intentos++;
                if(numeroIngresado == numeroGanador)
                {
                    ganador = 1;
                    Console.WriteLine("Felicitaciones, adivinaste!");
                }
                else
                {
                    if (intentos == 5)
                    {
                        Console.WriteLine("Perdiste, el número era 5!");
                    }
                    else
                    {
                        Console.WriteLine($"Error. te quedan {5-intentos} intentos");
                    }
                }
                
            }

        }
    }
}

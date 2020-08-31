using System;
using System.Xml;

namespace _18_08_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

//Ejercicio 1
            Console.WriteLine("Que estilo musical es el que mas te gusta?\n1_Rap\n2_Rock\n3_Pop\n4_Reggae\n5_Reggaeton\n6_Música Clasica");
            string valorIngresado = Console.ReadLine();
            int valor;
            valor = int.Parse(valorIngresado);

            if (valor == 1)
            {
                Console.WriteLine("El Rap es un buen género.");
            }
            else if (valor == 2)
            {
                Console.WriteLine("El Rock es uno de los géneros mas conocidos y respetados.");
            }
            else if (valor == 3)
            {
                Console.WriteLine("El Pop fue muy famoso en los 80's.");
            }
            else if (valor == 4)
            {
                Console.WriteLine("Bob Marley fue uno de los pioneros del género Reggae");
            }
            else if (valor == 5)
            {
                Console.WriteLine("El Reggaeton se baila en todo el mundo.");
            }
            else if (valor == 6)
            {
                Console.WriteLine("La música clásica nunca pasa de moda");
            }
            else
            {
                Console.WriteLine("Ingresaste una opción no válida!");
            }


//Ejercicio 2
            int num = 0;
            int totalNumIngresados = 0;
            for (int Ningreso = 0; Ningreso < 10; Ningreso++)
            {
                if(Ningreso == 0)
                {
                    Console.WriteLine("Ingrese diez números. Si sumados a los anteriores excede a 50, ganarás el juego");
                }
                else
                {
                    Console.WriteLine("Ingrese otro número");
                }

                string numero = Console.ReadLine();

                num = int.Parse(numero);

                ;

                totalNumIngresados += num;
                Console.WriteLine($"el número ingresado es {num}. El total al momento es de: {totalNumIngresados}");
            }
            if (num>50)
            {
                Console.WriteLine($"Felicidades! Excediste los 50!");
            }
            else
            {
                Console.WriteLine($"Tu número no excede los 50!");
            }


        }
    }
}

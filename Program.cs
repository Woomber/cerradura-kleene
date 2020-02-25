using System;
using System.Collections.Generic;

namespace CerraduraKleene
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPalabras, nivel;
            List<string> lenguaje = new List<string>();
            List<string> nuevoLenguaje;

            Console.WriteLine("Bienvenido al programa de Cerradura de Kleene\nPor Yael Arturo Chavoya Andalón 18310060\n");

            // Leer lenguaje
            Console.Write("Escriba el número de palabras en el lenguaje:\n> ");
            numPalabras = int.Parse(Console.ReadLine());

            for (int idx = 1; idx <= numPalabras; idx++)
            {
                Console.Write($"Palabra {idx}: ");
                lenguaje.Add(Console.ReadLine());
            }

            // Leer nivel
            Console.Write("\n\nEscriba el nivel que quiere calcular:\n> ");
            nivel = int.Parse(Console.ReadLine());

            // Cálculo
            try
            { 
                nuevoLenguaje = NivelCerradura.Calcular(nivel, lenguaje);
            } catch(Exception ex)
            {
                Console.WriteLine($"El nivel no se pudo calcular\n{ex.Message}");
                return;
            }
           

            // Mostrar resultado
            Console.WriteLine($"\n\nEl nivel {nivel} del lenguaje:");
            ImprimirLenguaje(lenguaje);
            Console.Write("\n\nes:\n");
            ImprimirLenguaje(nuevoLenguaje);

            Console.Write("\n\n");
            Console.WriteLine($"Tiene {nuevoLenguaje.Count} palabras");
            
        }

        private static void ImprimirLenguaje(List<string> lenguaje)
        {
            foreach (var palabra in lenguaje)
            {
                Console.Write(palabra + " ");
            }
        }

    }
}

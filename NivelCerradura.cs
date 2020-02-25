using System;
using System.Collections.Generic;
using System.Text;

namespace CerraduraKleene
{
    static class NivelCerradura
    {

        private static int Nivel = 1;
        private static List<string> Lenguaje = null;

        public static List<string> Calcular(int nivel, List<string> lenguaje)
        {
            if(nivel < 1)
            {
                throw new Exception("El nivel debe ser mayor o igual a uno");
            }

            if (lenguaje == null)
            {
                throw new Exception("El lenguaje no puede ser nulo");
            }

            Nivel = nivel;
            Lenguaje = lenguaje;

            return CalcularRecursivo(1, lenguaje);
        }

        private static List<string> CalcularRecursivo(int nivelActual, List<string> lenguajeActual)
        {
            if (nivelActual == Nivel)
            {
                return lenguajeActual;
            }

            var nuevoLenguaje = new List<string>();

            foreach(string palabra in Lenguaje)
            {
                foreach(string palabra2 in lenguajeActual)
                {
                    nuevoLenguaje.Add(palabra + palabra2);
                }
            }

            return CalcularRecursivo(nivelActual + 1, nuevoLenguaje);
        }
    }
}

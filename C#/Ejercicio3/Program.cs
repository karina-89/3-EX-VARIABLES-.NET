using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ciudad1 = "Barcelona";
            var ciudad2 = "Madrid";
            var ciudad3 = "Valencia";
            var ciudad4 = "Malaga";
            var ciudad5 = "Cadiz";
            var ciudad6 = "Santander";

            string[] arrayCiudades = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };

            string[] arrayCiudadesModificadas = new string[arrayCiudades.Length];

            for (int i = 0; i < arrayCiudades.Length; i++)
            {
                arrayCiudadesModificadas[i] = arrayCiudades[i].Replace('a', '4');
            }

            foreach (var ciudadModificada in arrayCiudadesModificadas)
            {
                Console.WriteLine(ciudadModificada);
            }
        }
    }
}

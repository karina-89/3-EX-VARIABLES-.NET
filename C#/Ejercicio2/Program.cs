using System;

namespace Ejercicio2
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

            for (int i = 0; i < arrayCiudades.Length; i++)
            {
                for (int j = 0; j < arrayCiudades.Length - 1; j++)
                {
                    if (arrayCiudades[j].CompareTo(arrayCiudades[j + 1]) > 0)
                    {
                        var temp = arrayCiudades[j];
                        arrayCiudades[j] = arrayCiudades[j + 1];
                        arrayCiudades[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Las ciudades ordenadas son:");
            foreach (var ciudad in arrayCiudades)
            {
                Console.WriteLine(ciudad);
            }
        }
    }
}

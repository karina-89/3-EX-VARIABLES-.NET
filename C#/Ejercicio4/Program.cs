using System;

namespace Ejercicio4
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

            char[] ciudad1Array = new char[ciudad1.Length];
            char[] ciudad2Array = new char[ciudad2.Length];
            char[] ciudad3Array = new char[ciudad3.Length];
            char[] ciudad4Array = new char[ciudad4.Length];
            char[] ciudad5Array = new char[ciudad5.Length];
            char[] ciudad6Array = new char[ciudad6.Length];

            for (int i = 0; i < ciudad1.Length; i++)
            {
                ciudad1Array[i] = ciudad1[i];
            }
            for (int i = 0; i < ciudad2.Length; i++)
            {
                ciudad2Array[i] = ciudad2[i];
            }
            for (int i = 0; i < ciudad3.Length; i++)
            {
                ciudad3Array[i] = ciudad3[i];
            }
            for (int i = 0; i < ciudad4.Length; i++)
            {
                ciudad4Array[i] = ciudad4[i];
            }
            for (int i = 0; i < ciudad5.Length; i++)
            {
                ciudad5Array[i] = ciudad5[i];
            }
            for (int i = 0; i < ciudad6.Length; i++)
            {
                ciudad6Array[i] = ciudad6[i];
            }

            string ciudadInvertida = "";
            for (int i = ciudad1Array.Length - 1; i >= 0; i--)
            {
                ciudadInvertida = ciudadInvertida + ciudad1Array[i];
            }
            Console.WriteLine(ciudad1 + " --> " + ciudadInvertida);

            ciudadInvertida = "";
            for (int i = ciudad2Array.Length - 1; i >= 0; i--)
            {
                ciudadInvertida = ciudadInvertida + ciudad2Array[i];
            }
            Console.WriteLine(ciudad2 + " --> " + ciudadInvertida);

            ciudadInvertida = "";
            for (int i = ciudad3Array.Length - 1; i >= 0; i--)
            {
                ciudadInvertida = ciudadInvertida + ciudad3Array[i];
            }
            Console.WriteLine(ciudad3 + " --> " + ciudadInvertida);

            ciudadInvertida = "";
            for (int i = ciudad4Array.Length - 1; i >= 0; i--)
            {
                ciudadInvertida = ciudadInvertida + ciudad4Array[i];
            }
            Console.WriteLine(ciudad4 + " --> " + ciudadInvertida);
            
            ciudadInvertida = "";
            for (int i = ciudad5Array.Length - 1; i >= 0; i--)
            {
                ciudadInvertida = ciudadInvertida + ciudad5Array[i];
            }
            Console.WriteLine(ciudad5 + " --> " + ciudadInvertida);

            ciudadInvertida = "";
            for (int i = ciudad6Array.Length - 1; i >= 0; i--)
            {
                ciudadInvertida = ciudadInvertida + ciudad6Array[i];
            }
            Console.WriteLine(ciudad6 + " --> " + ciudadInvertida);
        }
    }
}

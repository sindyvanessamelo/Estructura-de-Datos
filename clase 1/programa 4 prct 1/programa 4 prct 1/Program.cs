using System;

namespace programa_4_prct_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14159f;
            float area = 0.0f;
            string entrada = "";

            Console.WriteLine("Hola, hoy vamos a calcular el radio de un circulo tieniendo el área");
            Console.WriteLine("");

            Console.WriteLine("Digita el area");
            entrada = Console.ReadLine();
            area = Convert.ToSingle(entrada);

            var bs = Math.Sqrt(area / pi);
            Console.WriteLine("El valor de pi es = {0} y el valor del erea es {1} por lo tanto el resultado es {2}", pi, area, bs);

        }
    }
}

using System;

namespace programa3prct1
{
    class Program
    {
        static void Main(string[] args)
        {
            //escribir un algoritmo que permite calcular la base de un triangulo teniendo la superficie y la altura//

            float super = 0.0f;
            float alt = 0.0f;
            float resultado = 0.0f;
            string entrada = "";

            Console.WriteLine("hola, hoy vamos a hallar la base de un triangulo");
            Console.WriteLine("");
            Console.WriteLine("por favor digite el valor de la superficie:");
            entrada = Console.ReadLine();
            super = Convert.ToSingle(entrada);

            Console.WriteLine("ahora digita el valor de la altura");
            entrada = Console.ReadLine();
            alt = Convert.ToSingle(entrada);

            resultado = (2 * super) / alt;
            Console.WriteLine(" El valor de la superficie es igual a : {0}, la altura digitada es de :{1} por lo tanto la base del triangulo es de:{2}", super, alt, resultado);

        }
    }
}

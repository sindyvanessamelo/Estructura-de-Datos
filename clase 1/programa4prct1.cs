using System;

namespace programa4prct1
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1416f;
            float area = 0.0f;
            string entrada = "";


            Console.WriteLine("hola, hoy vamos a calcular el radio de un círculo");
            Console.WriteLine("");
            Console.WriteLine("por favor digite el valor del area:");
            entrada = Console.ReadLine();
            area = Convert.ToSingle(entrada);
            Console.WriteLine("");
            var bs = Math.Sqrt(area / pi);
            Console.WriteLine("el valor del area es de:{0} por lo tanto el valor de el radio del circulo es de:{1}", area, bs);
        }
    }
}

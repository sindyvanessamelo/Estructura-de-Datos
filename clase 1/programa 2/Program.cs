using System;

namespace proyecto02
{
    class Program
    {
        static void Main(string[] args)
       
            {
                float pi = 3.1416f;
                float rad = 0.0f;
                float ar = 0.0f;
                float petr = 0.0f;
                string entrada = "";


                Console.WriteLine("Hola, hoy vamos a sacar el área de un círculo");
                Console.WriteLine("");
                Console.WriteLine("regalame la medida del radio:");
                entrada = Console.ReadLine();
            rad = Convert.ToSingle(entrada);

            petr = (2 * pi) * rad;
                Console.WriteLine("el valor del perimetro es de : {0}", petr);
                Console.WriteLine("");
                ar = (pi * rad * rad);
                Console.WriteLine("el valor del area de tu circulo es de :{0}", ar);
                Console.WriteLine("");

        }
    }
}

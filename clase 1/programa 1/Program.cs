using System;

namespace programa_1
{

    class Program
    {
        
        //escribir un algoritmo que permita calcular la superficie de un triangulo//
        
        static void Main(string[] args)
        {
            string entrada = "";
            int b = 0;
            int alt = 0;
            int superficie = 0;
         
            Console.WriteLine("hola, hoy vamos a hallar el valor de la superficie de un triangulo");
            Console.WriteLine("");

            Console.WriteLine("digita el valor de la base");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);

            Console.WriteLine("digita el valor de la altura");
            entrada = Console.ReadLine();
            alt = Convert.ToInt32(entrada);

            superficie = (b * alt) / 2;
            Console.WriteLine(" el valor digitado de la base es= {0} y el valor digitado de la altura es = {1} por lo tanto el valor de la superficie del triangulo es de {2}", b, alt, superficie);





        }
    }
}

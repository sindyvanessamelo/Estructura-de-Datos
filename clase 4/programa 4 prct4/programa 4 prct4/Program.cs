using System;


namespace programa_4_prct4
{
    class program
    {
        private int[] tmñ;
        static void Main(string[] args)
        {
            
            //crear un vector unidimensional donde tú le indiques el tamaño por teclado//
            int i = 0, numero = 0, tmñ = 0;

            Console.WriteLine("indicanos un número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(" e indicanos el tamaño del vector: ");
            tmñ = int.Parse(Console.ReadLine());
            int[] num = new int[tmñ];

            desarrollo(num, tmñ, numero);
            resultados(num, tmñ);


            static void desarrollo(int[] num, int tmñ, int numero)

            {
                int i;
                for (i = 1; i <= tmñ; i++)
                {
                    num[i-1] = numero * i;
             
                }
            }

            static void resultados(int[] num, int tmñ)

            {
                int i;
                for (i = 1; i <= tmñ; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine(num[i-1]);
                }
            }   

        }
    }
}

    



    
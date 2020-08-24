using System;

namespace programa3clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, c;
            c = 0;
            Console.WriteLine("Ingresa Numero");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c = c + 1;
                }
            }
            if (c > 2)
            {
                Console.WriteLine(" el número {0} No es primo ", n);
            }
            else
            {
                Console.WriteLine("el número {0} Es primo", n);
            }

        }
    }
}

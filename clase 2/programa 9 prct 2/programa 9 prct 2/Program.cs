using System;

namespace programa_9_prct_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 0, d = 0;
            int z = 0;


            switch (z)
            {
                case 0:
                    Console.WriteLine("Digita la cantidad de números");
                    a = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("Digita un número");
                        b = int.Parse(Console.ReadLine());

                        if (i == 0)
                        {
                            c = b;
                            d = b;
                        }
                        else if (i != 0)
                        {
                            if (b < d)
                            {
                                d = b;
                            }
                            if (b > c)
                            {
                                c = b;
                            }
                        }
                    }
                    Console.WriteLine("El número mayor es " + c);
                    break;
            }
        }
    }
}

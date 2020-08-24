using System;

namespace programa9prct2
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
                    Console.WriteLine("digite la cantidad de numeros a digitar");
                    a = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("escriba un numero");
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
                    Console.WriteLine("le numero mayor es " + c);
                    break;
            }

        }
    }
}

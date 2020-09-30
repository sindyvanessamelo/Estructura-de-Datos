using System;
using System.Collections;

namespace programa_9_prct_6
{
    class Program
    {
   
            static void Main(string[] args)
            {
                ArrayList lista1 = new ArrayList();

                lista1.Add(1);
                lista1.Add(2);
                lista1.Add(3);
                imprime(lista1);

                ArrayList lista2 = new ArrayList();

                lista2.Add(4);
                lista2.Add(5);
                lista2.Add(10);
                imprime(lista2);

                Console.WriteLine("La concatenación en forma ordena ordenada de las listas es:  ");

                static void imprime(ArrayList arreglo)
                {
                    foreach (int n in arreglo)
                        Console.Write("  {0},", n);
                    Console.WriteLine("\n—————————————");
                }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_15_prct4
{
    class Program
    {
        static void Main(string[] args)
        {
               
                int[] array = new int[8];
                int numero;


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Digita un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    array[i] = numero;
                }

            Console.WriteLine("\n\nEl numero mayor es: " + array.Max());
            Console.WriteLine("\n\nEl numero menor es: " + array.Min());
            Console.ReadKey();
        }

    }
    }


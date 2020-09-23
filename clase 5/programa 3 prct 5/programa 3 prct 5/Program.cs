using System;

namespace programa_3_prct_5
{
    class Program
    {
        //escribir una programa que llene una matriz de 5x5

        private int[,] mat;
        public void Cargar()
        {
            mat = new int[5, 5];

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("       digita el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
       
        public void Imprimirvector()
        {
            Console.WriteLine(" ");
            Console.WriteLine("   La matriz resultante es");
            Console.WriteLine(" ");


            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(" " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void diagonalprincipal()
        {
            //almacena la diagonal principal en un vector 
            
            Console.WriteLine(" ");
            Console.WriteLine("  la diagonal principal es:  ");
            Console.WriteLine(" ");

            for (int f = 0; f < 5; f++)
            {           
                for (int c = 0; c < 5; c++)
                {                
                    if (f == c)
                    {
                        Console.WriteLine(" " + mat[f, c]);
                    }
                }           
            } 
        }

        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.Imprimirvector();
            ma.diagonalprincipal();
        }
    }
}

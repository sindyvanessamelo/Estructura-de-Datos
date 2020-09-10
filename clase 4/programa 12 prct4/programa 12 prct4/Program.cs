using System;

namespace programa_12_prct4
{
    class Program
    { 
        static void Main(string[] args)
        {
            double aprobados;
            double desaprobados;
            double PromAprobados;
            double PromDesaprobados;
            double SumAprobados;
            double SumDesaprobados;
            int tamaño,f;
            string linea;

            Console.WriteLine("Digita la cantidad de notas");
            tamaño = int.Parse(Console.ReadLine());
            int[] NumerosAleatorios = new int[tamaño];

            aprobados = 0;
            desaprobados = 0;
            SumAprobados = 0;
            SumDesaprobados = 0;

            for (f = 0; f < NumerosAleatorios.Length; f++)
            {
                Console.Write("Ingrese el elemento del vector número [" + (f + 1) + "]: ");
                linea = Console.ReadLine();
                NumerosAleatorios[f] = int.Parse(linea);
            }


            if (NumerosAleatorios[f] > 10)
                {
                    aprobados = aprobados + 1;
                    SumAprobados = SumAprobados + NumerosAleatorios[f];
                }
                else
                {
                    desaprobados = desaprobados + 1;
                    SumDesaprobados = SumDesaprobados + NumerosAleatorios[f];
                }
            
            PromAprobados = SumAprobados / aprobados;
            PromDesaprobados = SumDesaprobados / desaprobados;

            Console.WriteLine("Hay " + aprobados + " aprobados");
            Console.WriteLine("Hay " + desaprobados + " desaprobados");
            Console.WriteLine("El promedio de los aprobados es " + PromAprobados);
            Console.WriteLine("El promedio de los desaprobados es " + PromDesaprobados);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace programa10pract02
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            double mujeres = 0;
            int edad ;
            int sexo , i;
            string entrada = "";
            float salario;
            double estado,homcado = 0;
    
                Console.Write("queremos conocer tu edad: ");
                entrada = Console.ReadLine();
                edad = Convert.ToInt32(entrada);
                Console.Write("1 = Femenino, 2 = Masculino:");
                entrada = Console.ReadLine();
                sexo = Convert.ToInt32(entrada);
                Console.Write("tu estado civil: 1 =soltero(a) / 2=casado(a) / 3=viudo(a) ");
                entrada = Console.ReadLine();
                estado = Convert.ToInt32(entrada);
                Console.Write("digita por favor tu salario:");
                entrada = Console.ReadLine();
                salario = Convert.ToSingle(entrada);
                Console.Write("queremos conocer tu edad: ");
                entrada = Console.ReadLine();
                edad = Convert.ToInt32(entrada);
                Console.Write("1 = Femenino, 2 = Masculino:");
                entrada = Console.ReadLine();
                sexo = Convert.ToInt32(entrada);
                Console.Write("tu estado civil: 1 =soltero(a) / 2=casado(a) / 3=viudo(a) ");
                entrada = Console.ReadLine();
                estado = Convert.ToInt32(entrada);
                Console.Write("digita por favor tu salario:");
                entrada = Console.ReadLine();
                salario = Convert.ToSingle(entrada);

                if (sexo == 1)
                {
                   mujeres = mujeres +sexo;

                    Console.WriteLine("Cantidad de mujeres: {0} ", mujeres);
                }
                else
                {
                    Console.WriteLine("no hay nigúna mujer registrada ");
                }

                if (sexo == 2 && estado == 2 && salario >=1000)
                {
                    homcado = homcado + sexo;
                    Console.WriteLine("sexo:{0}, estado civil: {1} y salario: {2} ", sexo,estado,salario);
                    Console.WriteLine("Cantidad de hombres:} ", homcado);
                }

            }
        }
    }
}

         
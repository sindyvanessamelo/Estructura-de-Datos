﻿using System;

namespace desarrolloejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double sexo = 0, estado = 0, trabajador = 0;
            double mujeres = 0, hombres = 0, totalmujeres = 0, totalhombres = 0, promedio = 0, edad = 0, edadpromedio = 0;
            string entrada = "";

            Console.WriteLine("digita cantidad de trabajadores:  ");
            trabajador = int.Parse(Console.ReadLine());

            for (int i = 0; i < trabajador; i++)
            {
                Console.WriteLine("{0}º trabajador", i + 1);

                Console.WriteLine("1- Femenino:  ");
                Console.WriteLine("2-Masculino:  ");
                Console.Write("tu sexo es:  ");
                entrada = Console.ReadLine();
                sexo = Convert.ToInt32(entrada);

                Console.Write("1- soltero(a): ");
                Console.Write("2- casado (a): ");
                Console.Write("3- viudo  (a): ");
                Console.Write("tu estado civil:  ");
                entrada = Console.ReadLine();
                estado = Convert.ToInt32(entrada);
                Console.Write("");

                Console.Write("¿cuantós años tienes?  ");
                entrada = Console.ReadLine();
                edad = Convert.ToInt32(entrada);
                Console.Write("");

                Console.Write("¿cuantó es tu salario?  ");
                entrada = Console.ReadLine();
                sexo = Convert.ToInt32(entrada);
                Console.WriteLine("");
                
                if (sexo == 1)
                {
                    mujeres = mujeres + sexo;
                }

                /*switch (sexo)

                {

                    case 1:
                        if (sexo == 1 || estado == 3 || salario >= 600) //Total de mujeres viudas que ganan másde 600 Bs
                        {
                            totalmujeres = totalmujeres + sexo;
                            //Console.WriteLine("Total de mujeres viudas que ganan más de 600 Bs: {0}", totalmujeres);//
                        }
                        break;

                    case 2:
                        if (sexo == 2 || estado == 2 || salario >= 1000) //Total de hombres casados que ganan más de 1000 Bs.F.
                        {
                            totalhombres = totalhombres + sexo;
                           // Console.WriteLine("Total de hombres casados que ganan más de 1000 Bs: {0}", totalhombres);//
                        }
                        break;
                    case 3:
                      
                        break;
                    case 4:
                        if (sexo == 2)
                        {
                            hombres = hombres + sexo;
                            edadpromedio = edadpromedio + edad;
                            promedio = edadpromedio / hombres;

                        }                    
                        break;
                }

 
                */
            }
            
            //Console.WriteLine("cantidad de hombres: {0} ", hombres);
           // Console.WriteLine("promedio de edad hombres: {0} ", promedio);//
            Console.WriteLine("total de mujeres: {0} ", mujeres);
        }

        }

  }
        
    



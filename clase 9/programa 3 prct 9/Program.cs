using System;

namespace programa_3_prct_9
{
    class Program
    {
        class Socio
        {
            private string nombre;
            private int antiguedad;

            public Socio()
            {
                Console.Write("Ingrese el nombre del socio:");
                nombre = Console.ReadLine(); ;
                Console.Write("Ingrese años en la empresa:");
                string linea = Console.ReadLine();
                antiguedad = int.Parse(linea);
           
            }

            public void Imprimir()
            {
                Console.Write("");
                Console.WriteLine(nombre + " tiene " + antiguedad + " años en la empresa");
            }

            public int RetornarAntiguedad()
            {
                return antiguedad;
            }
        }


        class Club
        {
            private Socio socio1, socio2, socio3;

            public Club()
            {
                socio1 = new Socio();
                socio2 = new Socio();
                socio3 = new Socio();
            }

            public void MayorAntiguedad()
            {
                Console.Write("");
                Console.Write("Socio con mayor antiguedad:");
                if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                    socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio1.Imprimir();
                }
                else
                {
                    if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                    {
                        socio2.Imprimir();
                    }
                    else
                    {
                        socio3.Imprimir();
                    }
                }

            }

            static void Main(string[] args)
            {
                Club socios = new Club();
                socios.MayorAntiguedad();
                Console.ReadKey();
            }
        }
    }
}
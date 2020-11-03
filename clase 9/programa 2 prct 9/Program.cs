using System;

namespace programa_2_prct_9
{
    class empleado
    {
        private string nombre;
        private int sueldo;

        public empleado()
        {
            Console.Write("Ingrese nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su sueldo:");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("sueldo:" + sueldo);
        }

        public void sueldomayor()
        {
            Console.WriteLine("");
            if (sueldo >= 3000)
            {
                Console.Write(nombre + " debes pagar impuestos");
            }
            else
            {
                Console.Write(nombre + " no debes pagar impuestos.");
            }
        }

        static void Main(string[] args)
        {
            empleado trabajador = new empleado();
            trabajador.Imprimir();
            trabajador.sueldomayor();
            Console.ReadKey();
        }
    }
}


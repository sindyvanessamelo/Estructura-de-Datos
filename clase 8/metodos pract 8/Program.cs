using System;

namespace metodos_pract_8
{
    
        //clase object,  metodo tostring()
        public class ClaseBasica
        {
            public string hola = "hola";
            public string saludo = "¿cómo estas?";
        }
        class Program
        {
            static void Main(string[] args)
            {
            //metodo tostring
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("clase object, método tostring:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            object Objeto;
            Objeto = new ClaseBasica();
            ClaseBasica c;
            c = (ClaseBasica)Objeto;
            Console.WriteLine(c.hola);
            ClaseBasica u = new ClaseBasica();
            Console.WriteLine(u.saludo);
            Console.WriteLine("______________________________________");
            Console.ReadLine();

            //metodo datetime
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("clase date, método datetime:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            DateTime today = DateTime.Today;
            Console.WriteLine("hoy es " + today.ToString("MMMM, dd, yyyy") + ".");
            Console.Write("Dentro de 5 dias sera: ");
            Console.WriteLine(today.AddDays(5));
            Console.ReadLine();
        }
        }
    }



using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Progrmas_prct_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // método PadRight//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo padright:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string str = "hola";
            char pad = 'a';
            Console.WriteLine(str.PadRight(15, pad));    
            Console.WriteLine(str.PadRight(2, pad));
            Console.WriteLine("______________________________________");
            Console.ReadLine();


            //método Remove//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo remove:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            List<int> myPartyAges = new List<int> { 12, 23, 45, 65 };
            foreach (int o in myPartyAges)
                Console.WriteLine(o);

            Console.WriteLine("");
            Console.WriteLine("eliminamos el número 12 ");
            Console.WriteLine("");
            myPartyAges.Remove(12);
            foreach (int p in myPartyAges)
                Console.WriteLine(p);

            //Replace//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo replace:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string sentece = "Hola, mi nombre es Pepe.";
            Console.WriteLine("{0}", sentece);
            string after = sentece.Replace('a','i');
            Console.WriteLine("The final string: '{0}'", after);
            Console.WriteLine("______________________________________");
            Console.ReadLine();

            //Split//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo split:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string cadena = "ingenieria de software";
            string[] arreglo = cadena.Split();
            for (int o = 0; o < arreglo.Length; o++)
            {
                Console.WriteLine(arreglo[o]);
            }
            Console.WriteLine("______________________________________");
            Console.ReadKey();

            //ToLower ToUppert//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo tolower y touppert:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string a = "buenas tardes";
            Console.WriteLine(a);
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine("______________________________________");
            Console.ReadLine();

            //TrimStart//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo trimstart:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string s1 = "*****000hola 000****";

            char[] charsToTrim1 = { '*', '0' };

            string s2 = "  hola   ";
 
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("");
            Console.WriteLine(s1.TrimStart(charsToTrim1));
            Console.WriteLine(s2.TrimStart());
            Console.WriteLine("______________________________________");
            Console.ReadLine();

            //TrimEnd//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo trimend:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s1.TrimEnd(charsToTrim1));
            Console.WriteLine(s2.TrimEnd());
            Console.WriteLine("______________________________________");
            Console.ReadLine();

            //Trim//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo trim:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string e = "hola,como estas";
            string f = "|"; 
            Console.WriteLine(e + f);
            Console.WriteLine(e.Trim() + f);
            Console.WriteLine("______________________________________");
            Console.ReadLine();

            //WriteLine//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo writeline:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hola a todos");
            Console.WriteLine("______________________________________");

            //ToString//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo tostring:   ");

            Console.ForegroundColor = ConsoleColor.White;
            bool SioNo = false;
            Console.WriteLine(SioNo.ToString());
            Console.WriteLine("______________________________________");
            Console.ReadLine();
        
            //AppendFormat//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo appendformat:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            StringBuilder builder = new StringBuilder();
            string[] data = { "hola", "bienvenido", "hello" };
            int counter = 0;
            foreach (string valu in data)
            {
                builder.AppendFormat(" {0} ({1}).\n",  valu,++counter);
            }
            Console.WriteLine(builder);

            //Append//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("metodo append:   ");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            string value = "fundación ";
            value += "unipanamericana";
            Console.WriteLine(value);
            value += " D.C";
            Console.WriteLine(value);
        }

        }
    }


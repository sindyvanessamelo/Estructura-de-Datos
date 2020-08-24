using System;

namespace programa2clase2
{
    class Program
    {
        static void Main(string[] args)
        {
     /* escribir el algoritmo que permita emitir la factura correspondiente a una compra de un artículo determinado del que se adquieren una o varias unidades. 
      * El IVA a aplicar es del 11.5% y si el precio bruto (precio de venta más IVA) es mayor de 500 Bs.F., se aplicará un descuento del 6.5%.*/
          
            

                float vv = 0.0f, iva = 0.0f, pv = 0.0f, preciototal = 0.0f;
                float desc = 0.065f;
                string articulo = "", entrada = "";
                int unidades = 0;

                System.Console.WriteLine("¿cuál artículo comprará?   ");
                entrada = System.Console.ReadLine();
                articulo = new string(entrada);

                System.Console.WriteLine("Digita por favor el valor del articulo =  ");
                vv = float.Parse(System.Console.ReadLine());

                System.Console.WriteLine(" ¿cuantás unidades comprará? ");
                unidades = int.Parse(System.Console.ReadLine());

                iva = vv * 0.115f;
                System.Console.WriteLine("valor iva= {0} ", iva);

                pv = vv + iva;

                if (pv >= 500)
                {
                    desc = 0.065f * vv;
                    preciototal = vv - desc;
                    System.Console.WriteLine("El precio de venta es= {0} pesos, más un descuento = {1} pesos, por lo tanto el total a pagar es de: {2} pesos", pv, desc, preciototal);
                }
                else
                {
                    System.Console.WriteLine("El precio de venta es= {0} ", pv);
                }
            
        }
    }
}

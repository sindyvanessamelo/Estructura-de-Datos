using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;

namespace programa_1_pract_10
{
    class Node
    {
        public class ArbolBinarioOrdenado
        {
            class Nodo
            {
                public int info;
                public Nodo izq, der;
            }
            Nodo raiz;

            public ArbolBinarioOrdenado()
            {
                raiz = null;
            }

            public void Insertar(int info)
            {


                // guardamos la información que llega al método en el nodo ""nuevo"
                Nodo nuevo;
                nuevo = new Nodo();
                nuevo.info = info;

                //Creamos un nodo y disponemos los punteros izq y der a null
                nuevo.izq = null;
                nuevo.der = null;

                //dentro de la estructura repetitiva vamos comparando info con la información del nodo
                if (raiz == null)
                    raiz = nuevo;

                //si info es mayor a la del nodo descendemos por el subárbol derecho en caso contrario
                //descendemos por el subárbol izquierdo.
                else
                {
                    Nodo anterior = null, reco;
                    reco = raiz;

                    //Cuando se encuentra un subárbol vacío insertar el nodo en dicho subárbol.
                    //Para esto llevamos un puntero anterior dentro del while.
                    while (reco != null)
                    {
                        anterior = reco;
                        if (info < reco.info)
                            reco = reco.izq;
                        else
                            reco = reco.der;
                    }
                    if (info < anterior.info)
                        anterior.izq = nuevo;
                    else
                        anterior.der = nuevo;
                }
            }

            //El método ImprimirPre(), es decir el no recursivo
            //se encarga de llamar al método recursivo pasando la dirección del nodo raiz.
            private void ImprimirPre(Nodo reco)
            {
                //if si reco está apuntando a un nodo (esto es verdad si reco es distinto a null)
                //en caso afirmativo ingresa al bloque del if.
                if (reco != null)
                {
                    //es la impresión de la información del nodo y los recorridos son las llamadas recursivas 
                    //pasando las direcciones de los subárboles izquierdo y derecho.
                    Console.Write(reco.info + " ");
                    ImprimirPre(reco.izq);
                    ImprimirPre(reco.der);
                }
            }

            public void ImprimirPre()
            {
                ImprimirPre(raiz);
                Console.WriteLine();
            }

            private void ImprimirEntre(Nodo reco)
            {
                //  recorrido en entreorden la visita la realizamos luego de las llamadas recursivas
                if (reco != null)
                {
                    ImprimirEntre(reco.izq);
                    Console.Write(reco.info + " ");
                    ImprimirEntre(reco.der);
                }
            }

            public void ImprimirEntre()
            {
                ImprimirEntre(raiz);
                Console.WriteLine();
            }


            private void ImprimirPost(Nodo reco)
            {
                // recorrido en postorden la visita la realizamos luego de las dos llamadas recursivas
                if (reco != null)
                {
                    ImprimirPost(reco.izq);
                    ImprimirPost(reco.der);
                    Console.Write(reco.info + " ");
                }
            }


            public void ImprimirPost()
            {
                ImprimirPost(raiz);
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
                abo.Insertar(100);
                abo.Insertar(50);
                abo.Insertar(25);
                abo.Insertar(75);
                abo.Insertar(150);
                Console.WriteLine("Impresion preorden: ");
                abo.ImprimirPre();
                Console.WriteLine("Impresion entreorden: ");
                abo.ImprimirEntre();
                Console.WriteLine("Impresion postorden: ");
                abo.ImprimirPost();
                Console.ReadKey();
            }
        }
    }
}
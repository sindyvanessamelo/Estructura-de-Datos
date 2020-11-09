using System;

namespace programa_2_prct_10
{
    class Program
    {
        public class ArbolBinarioOrdenado
        {
            // guardamos la información que llega al método en el nodo 
            class Nodo
            {
                public int info;
                public Nodo izq, der;
            }
            private Nodo raiz;
            private int cant;
            private int altura;

           
            public ArbolBinarioOrdenado()
            {
                raiz = null;
            }

            public void Insertar(int info)
            {
                if (!Existe(info))
                {
                    Nodo nuevo;
                    nuevo = new Nodo();
                    nuevo.info = info;
                    nuevo.izq = null;
                    nuevo.der = null;
                    if (raiz == null)
                        raiz = nuevo;
                    else
                    {
                        Nodo anterior = null, reco;
                        reco = raiz;
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
            }

            //un puntero reco en el nodo apuntado por raiz.
            //Dentro de un while verificamos si la información del parámetro coincide con la información del nodo apuntado por reco.
            public bool Existe(int info)
            {
                Nodo reco = raiz;
                while (reco != null)
                {
                    if (info == reco.info)
                        return true;
                    else
                        if (info > reco.info)
                        reco = reco.der;
                    else
                        reco = reco.izq;
                }
                return false;
            }

            private void ImprimirEntre(Nodo reco)
            {
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

            private void Cantidad(Nodo reco)
            {
                //Llamamos al método recursivo y en cada visita al nodo incrementamos el atributo cant
                if (reco != null)
                {
                    cant++;
                    Cantidad(reco.izq);
                    Cantidad(reco.der);
                }
            }

            public int Cantidad()
            {
                //inicializar un atributo de la clase llamado cant con cero.
                cant = 0;
                Cantidad(raiz);
                return cant;
            }

            private void CantidadNodosHoja(Nodo reco)
            {
                if (reco != null)
                {
                    if (reco.izq == null && reco.der == null)
                        cant++;
                    CantidadNodosHoja(reco.izq);
                    CantidadNodosHoja(reco.der);
                }
            }

            public int CantidadNodosHoja()
            {
                cant = 0;
                CantidadNodosHoja(raiz);
                return cant;
            }


            //Para imprimir todos los nodos en entre orden junto al nivel donde se encuentra planteamos un método recursivo
            //que llegue la referencia del nodo a imprimir junto al nivel de dicho nodo.
            private void ImprimirEntreConNivel(Nodo reco, int nivel)
            {
            // //Cada vez que descendemos un nivel le pasamos la referencia del subárbol respectivo junto al nivel que se encuentra dicho nodo
                if (reco != null)
                {
                    ImprimirEntreConNivel(reco.izq, nivel + 1);
                    Console.Write(reco.info + " (" + nivel + ") - ");
                    ImprimirEntreConNivel(reco.der, nivel + 1);
                }
            }

            public void ImprimirEntreConNivel()
            {
                ImprimirEntreConNivel(raiz, 1);
                Console.WriteLine();
            }

           //llamamos al método recursivo con la referencia a raiz que se encuentra en el nivel uno.
            private void RetornarAltura(Nodo reco, int nivel)
            {
     // Cada vez que visitamos un nodo procedemos a verificar si el parámetro nivel supera al atributo altura, en dicho caso actualizamos el atributo altura con dicho nivel.
                if (reco != null)
                {
                    RetornarAltura(reco.izq, nivel + 1);
                    if (nivel > altura)
                        altura = nivel;
                    RetornarAltura(reco.der, nivel + 1);
                }
            }

         //Para obtener la altura del árbol procedemos en el método no recursivo a inicializar el atributo altura con el valor cero
            public int RetornarAltura()
            {
                altura = 0;
                RetornarAltura(raiz, 1);
                return altura;
            }

         //Para imprimir el mayor valor del árbol debemos recorrer siempre por derecha hasta encontrar un nodo que almacene null
            public void MayorValorl()
            {
                if (raiz != null)
                {
                    Nodo reco = raiz;
                    while (reco.der != null)
                        reco = reco.der;
                    Console.WriteLine("Mayor valor del árbol:" + reco.info);
                }
            }
         //Para borrar el menor valor del árbol lo primero que comprobamos es si el subárbol izquierdo es nulo luego el menor del árbol es el nodo apuntado por raiz
         //si el subárbol izquierdo no está vacío procedemos a descender siempre por la izquierda llevando un puntero en el nodo anterior.   
            public void BorrarMenor()
            //si el subárbol izquierdo no está vacío procedemos a descender siempre por la izquierda llevando un puntero en el nodo anterior. 
            {
                if (raiz != null)
                {
                    if (raiz.izq == null)
                        raiz = raiz.der;
                    else
                    {
                        Nodo atras = raiz;
                        Nodo reco = raiz.izq;
                        while (reco.izq != null)
                        {
                            atras = reco;
                            reco = reco.izq;
                        }
                        atras.izq = reco.der;
                    }
                }
            }

            static void Main(string[] args)
            {
                ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
                abo.Insertar(100);
                abo.Insertar(50);
                abo.Insertar(25);
                abo.Insertar(75);
                abo.Insertar(150);
                Console.WriteLine("Entreorden: ");
                abo.ImprimirEntre();
                Console.WriteLine("Canntidad de nodos del árbol:" + abo.Cantidad());
                Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja());
                Console.WriteLine("Entre orden junto al nivel del nodo.");
                abo.ImprimirEntreConNivel();
                Console.Write("Altura del arbol:");
                Console.WriteLine(abo.RetornarAltura());
                abo.MayorValorl();
                abo.BorrarMenor();
                Console.WriteLine("Borrar el menor:");
                abo.ImprimirEntre();
                Console.ReadKey();
            }
        }
    }
}

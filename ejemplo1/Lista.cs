using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Lista
    {

        public Nodo inicio;

        public Lista()
        {
            inicio = null;
        }
        public void InsertarF(int item)
        {
            Nodo aux = new Nodo();
            aux.dato = item;
            aux.siguiente = null;

            if (inicio == null)
            {
                inicio = aux;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = aux;
            }
        }
        public void InsertarI(int item)
        {
            Nodo aux = new Nodo();

            aux.dato = item;
            aux.siguiente = null;

            if (inicio == null)
            {
                inicio = aux;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                inicio = aux;
                aux.siguiente = puntero;
            }
        }

        public void EliminarI()
        {
            if (inicio == null)
            {
                Console.WriteLine("lista vacias, no se puede eliminar la lista");
            }
            else
            {
                inicio = inicio.siguiente;
            }
        }
        public void EliminarF()
        {
            if (inicio == null)
            {
                Console.WriteLine("lista vacia, no se puede eliminar elemento");
            }
            else
            {
                Nodo punteroant, punteropost;
                punteroant = inicio;
                punteropost = inicio;

                while (punteropost.siguiente != null)
                {
                    punteroant = punteropost;
                    punteropost = inicio;
                }
                punteroant.siguiente = null;
            }

        }
        public void InsertarP(int item, int pos)
        {
            Nodo aux = new Nodo();
            aux.dato = item;
            aux.siguiente = null;

            if (inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = aux;
                    aux.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }
                    Nodo punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = punteronext;
                    aux.siguiente = punteronext;
                }
            }
        }
        public void mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                Console.Write("{0} -> \t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> ", puntero.dato);
                }
            }
            Console.WriteLine();

        }


    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazada
{
    public class ListaNodo
    {
        private Nodo primero;
        private int size;

        public ListaNodo()
        {
            this.primero = null;
            this.size = 0;
        }
        /*Metodo para agregar datos*/
        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);// adherimos el nodo de tipo entero se almacena en el nodo, cada vez se crea un nuevo nodo.
            Nodo valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
            else
            {
                valor1 = primero;
                while (valor1 != null)
                {
                    valor2 = valor1.siguiente;
                    /*Conficion que verifica si el nuevo entrante debe ir primero*/
                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        //condición que verifica si el numero entrante debe de ir al último:
                        if (nuevo.dato > valor1.dato && valor2 == null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            /*Conficion que verifica si el numero debe ir en medio de otro nodo*/
                            if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
                            {
                                valor1.siguiente = nuevo;
                                nuevo.siguiente = valor2;
                                break;
                            }
                            else
                            {
                                valor1 = valor1.siguiente;
                            }
                        }
                    }
                }
            }
            size++;
        }
        public void listaVacia()
        {
            if (primero==null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine("la lista tiene datos");
            }
        }
        public void Listar()
        {
            Nodo actual = primero;
            while (actual!=null)
            {
                Console.Write($"[{actual.dato}]->");
                actual = actual.siguiente;
            }
        }
        public void DeleteFirst()
        {
            primero = primero.siguiente;/*Elimina el primer nodo*/
        }
        public void DeleteLast()
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            while (actual.siguiente!=null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            anterior.siguiente = null;
        }
        public void deletePosicionNodo(int p)
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            int dato = 0;
            if (p > 0)
            {
                while (dato != p && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    dato++;
                }
                anterior.siguiente = actual.siguiente;
            }
        }
        public Nodo Buscar(int n)
        {
            Nodo p = primero;
            if (p == null)
            {
                Console.WriteLine("La lista no tiene datos");
            }
            else
            {
                while (p.siguiente != null || p.siguiente == null)
                {
                    if (p.dato == n)
                    {
                        return p;
                    }
                    else
                    {
                        if (p.siguiente == null)
                        {
                            return null;
                        }
                    }
                    p = p.siguiente;
                    
                }
            }
            return null;
        }
        public void Sustituir(int orig, int nuevo)
        {
            Nodo pos = Buscar(orig);
            if (pos!=null || pos==null)
            {
                pos.dato = nuevo;
            }
        }
        public int Size()
        {
            return size;
        }
    }
}

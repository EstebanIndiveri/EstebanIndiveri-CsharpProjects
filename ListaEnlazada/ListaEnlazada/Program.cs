using System;
using System.Collections.Generic;

namespace ListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea listas enlazadas*/

            LinkedList<String> nodo = new LinkedList<string>();

            ListaNodo list = new ListaNodo();

            //list.listaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            list.Listar();
            //list.DeleteFirst();
            Console.WriteLine("");
            //list.Listar();
            //Console.WriteLine("");
            list.Sustituir(3,6);
            Console.WriteLine(list.Size());
            Console.WriteLine(list.Buscar(3));
            /*list.deletePosicionNodo(1);*/
            list.Listar();
            //list.listaVacia();
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

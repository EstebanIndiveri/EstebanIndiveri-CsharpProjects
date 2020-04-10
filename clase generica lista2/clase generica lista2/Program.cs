using System;
using System.Collections.Generic;

namespace clase_generica_lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Object> lista = new List<object>();
            lista.Add("Noblex");
            lista.Add(32);
            lista.Add(true);
            lista.Add("ILO 1");
            lista.Add("ILO");
            lista.Insert(1, "ILO");
            Console.WriteLine(lista.Exists(e=>e.Equals("Noblex")));
            Console.WriteLine(lista.LastIndexOf("ILO"));
            //lista.Clear();

            //lista.Reverse();
            Console.WriteLine(lista.Contains(732));
           // Console.WriteLine(lista.IndexOf("ILO",0,2));
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

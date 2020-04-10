using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericasCurso
{
    public class Nodo<T>
    {
        public T obj;
        public Nodo<T> next;
        public Nodo(T obj)
        {
            this.obj = obj;
            next = null;
        }
    }
}

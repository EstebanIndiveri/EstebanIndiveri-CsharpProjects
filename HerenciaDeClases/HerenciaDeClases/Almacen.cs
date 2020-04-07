using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaDeClases
{
    public abstract class Almacen
    {
        public abstract List<Producto> getProducto(String producto);
        public abstract void addProducto(Producto producto);
    }
}

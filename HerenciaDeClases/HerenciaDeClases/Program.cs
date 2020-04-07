using System;

namespace HerenciaDeClases
{
    class Program : Menu
    {
        /*public Program(String s) : base(s)
        {

        }*/
        static void Main(string[] args)
        {
            new Program().golosinas();

            //var menu = new Menu("Hola");
            //menu.getProducto();
            /*new Program().getProducto();*/
            //Console.WriteLine("Hello World!");
        }
        /*
        public void addProductos()
        {
            throw new NotImplementedException();
        }

        /*Se esta llamando a este metodo ya sobreEscrito
        public override void getProducto()
        {
            /*Console.WriteLine(s);
            Console.WriteLine("Hola");
        }
    }
    interface IProductos{

        void addProductos();
    
    }*/
        
    }
}

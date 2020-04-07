using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaDeClases
{
    public class Menu : IMenu
    {
        Almacen golosina = new Golosinas();

        public void golosinas()
        {
            var des = "";
            var valor = false;
            var id = 0;
            do
            {
                Console.Clear();// limpiamos la consola
                Console.WriteLine("Venta de golosinas");
                if (golosina.getProducto("").Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas disponsibles");
                    Console.WriteLine("Desea agregar golosinas? presione la teclas s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuantas golosinas va a agregar?");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Nueva golosina");
                            //Console.WriteLine("Ingrese un identificador");
                            //var id = Console.ReadLine();
                            id++;
                            Console.WriteLine("Ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            golosina.addProducto(new Producto
                            {
                                ID = Convert.ToString(id),
                                Nombre = nombre,
                                Precio = precio
                            });
                        }
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de golosinas y frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach(var item in golosina.getProducto(""))
                    {
                        Console.WriteLine($"Código {item.ID}, Golosina {item.Nombre}, Precio {item.Precio}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        ventas();
                    }
                    else
                    {
                        valor = false;
                    }
                }
                       
            } while (valor) ;
        }
        public void ventas()
        {
            double total = 0;
            string des = "";
            do
            {
                Console.WriteLine("Ingrese el producto");
                string producto = Console.ReadLine();
                var productos = golosina.getProducto(producto);
                while (productos.Count.Equals(0))
                {
                    Console.WriteLine("Golosonia no disponible, por favor seleccione otro.");
                    producto = Console.ReadLine();
                    productos = golosina.getProducto(producto);
                }
                Console.WriteLine($"Su monto a pagar es: $ {productos[0].Precio} Pesos");
                double pago = solicitarPago();
                while (pago < productos[0].Precio)
                {
                    Console.WriteLine("Faltan $ " + (productos[0].Precio - pago).ToString() + " Pesos");
                    pago += solicitarPago();
                }
                Console.WriteLine("Su cambio: $ " + (pago - productos[0].Precio).ToString());
                total += productos[0].Precio;
                Console.WriteLine("Su pago fue de $ " + total.ToString() + " Pesos");
                Console.WriteLine("¿Realizar otra compra? s/n");
                des = Console.ReadLine();
            } while (des.Equals("s"));
        }
        public double solicitarPago()
        {
            bool pagoCorrecto = false;
            double res = 0;
            while (!pagoCorrecto)
            {
                Console.WriteLine("Como desea pagar?");
                res = double.Parse(Console.ReadLine());
                if (res!=5&& res!=10)
                {
                    Console.WriteLine("Pago no valido");
                }
                else
                {
                    pagoCorrecto = true;
                }
            }
            return res;
        }
        //private string s;

        //public Menu(string s)
        //{
        //    this.s = s;
        //    getProducto();
        //}

        //public override void getProducto()
        //{
        //     Console.WriteLine(s);
        //}


        ///* public virtual void getProducto()
        // {
        //     Console.WriteLine(s);
        // }*/
    }
}

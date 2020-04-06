using System;

namespace variables_estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var data = new Conversor();
            data.Conversor1();
            //Conversor.velocidad = 3.0;
            var data1 = new Conversor();
            data1.Conversor2();
            /*Conversor.velocidad = 4.2;
            Conversor.Conversor1();
            Conversor.Conversor2();
            */
            int opcion, repetir = 0;
            var con = new Conversor();
            do
            {
                Console.WriteLine("Escoja una de las opciones");
                Console.WriteLine("1- Convertir m/s a km/h");
                Console.WriteLine("2- Convertir km/h a m/s");
                opcion = Convert.ToInt32(Console.ReadLine());/*Convertimos el string en entero*/
                switch (opcion)
                {
                    case 1:
                        con.Conversor1();
                        break;
                    case 2:
                        con.Conversor2();
                        break;
                    default:
                        Console.WriteLine("No se pudo completar la operación");
                        break;
                }
                Console.WriteLine("Si desea repetir coloque el valor de 1 o cualquier tecla para salir");
                repetir = Convert.ToInt32(Console.ReadLine());
            } while (repetir==1);
        }

        /*static*/ class Conversor
        {
           /* public Conversor()
            {

            }*/
            /*static Conversor()
            {

            }*/
            private /*static*/  double velocidad;
            public  /*static*/ void Conversor1()
            {
                Console.WriteLine("Introduzca una velocidad en m/s");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(velocidad + " m/s = " + velocidad * 3600 / 1000 + " km/h");
            }
            public  /*static*/ void Conversor2()
            {
                Console.WriteLine("Introduzca una velocidad en k/h");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(velocidad + "km/h =  " + velocidad * 1000 / 3600 + " m/s");
            }
        }
    }
}

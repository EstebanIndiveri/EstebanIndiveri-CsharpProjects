using System;
using System.Text;

namespace Propiedades1
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante1 = new Estudiante()
            {
                nombre = "Noblex",
                apellido = "ilo",
                edad = 20,
                calificacion=85.6
            };
            var estudiante2=new Estudiante()
            {
                nombre="Mentor",
                apellido="Book",
                edad=40,
                calificacion=87.4
            };
            var estudiante3 = new Estudiante()
            {
                nombre = "Rotarix",
                apellido = "OFF",
                edad = 19,
                calificacion = 68.5
            };
            /*Cremos la lista de objetos*/
            var listaEstudiantes = new School();
            listaEstudiantes.agregarEstudiante(estudiante1);
            listaEstudiantes.agregarEstudiante(estudiante2);
            listaEstudiantes.agregarEstudiante(estudiante3);
            bool valor = false;
            do
            {
                Console.WriteLine("Ingrese el nombre");
                String name = Console.ReadLine();
                /*pasas el name y retorna un bool*/
                valor = listaEstudiantes.buscarPorNombre(name);
            } while (valor);
            /*Consola en tiempo de espera*/
            Console.ReadKey();
            /* var data2 = new estudiante();
             data2.nombre2 = "nombre2";
             var name2 = data2.nombre2;*/

            /* Console.WriteLine($"{nombre}, {name2}");*/
        }
    }
}

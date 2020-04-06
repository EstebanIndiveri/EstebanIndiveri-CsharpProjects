using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades1
{
    public class School
    {
        private List<Estudiante> estudiantes;
        public School()
        {
            estudiantes = new List<Estudiante>();
        }
        public void agregarEstudiante(Estudiante nuevoEstudiante)
        {
            estudiantes.Add(nuevoEstudiante);
        }
        public bool buscarPorNombre(String name)
        {
            bool encontrado = false;
            int i = 0;
            while(encontrado==false && i < estudiantes.Count)
            {
                if (estudiantes[i].nombre.Equals(name))
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("Name: " + estudiantes[i].nombre + " \n" + "Last Name: " + estudiantes[i].apellido + " \n" + "Calificación: " + estudiantes[i].calificacion);
                return false;
            }
            else
            {
                Console.WriteLine("No se encuentra en nombre buscado, intenta nuevamente...!");
                return true;
            }
        }
    }
}

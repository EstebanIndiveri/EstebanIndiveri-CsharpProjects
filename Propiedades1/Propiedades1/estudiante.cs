using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades1
{
    public class Estudiante
    {
        public String nombre { get; set; }
        /*public String nombre2 {
            get { return nombre;}
            set{nombre = value;} 
        }*/
        public int edad { get; set; }
        
        public String apellido { get; set; }
        public double calificacion { get; set; }
    }
}

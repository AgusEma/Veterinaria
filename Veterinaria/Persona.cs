using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Persona
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public int dni { get; set; }
        
        public Persona(String nombre, String apellido, String telefono, String direccion, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.dni = dni;
        }
    }
}

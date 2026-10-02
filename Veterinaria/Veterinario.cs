using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Veterinario : Persona
    {
        public String licencia { get; set; }
        public bool disponibilidad { get; set; }
        public String especialidad { get; set; }

        public Veterinario(String nombre, String apellido, String telefono, String direccion, int dni, String licencia, bool disponibilidad, String especialidad) : base(nombre, apellido, telefono, direccion, dni)
        {
            this.licencia = licencia;
            this.disponibilidad = disponibilidad;
            this.especialidad = especialidad;
        }
    }
}

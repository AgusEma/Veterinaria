using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Cliente : Persona
    {
        public List<Mascota> mascotas { get; set; }

        public Cliente(String nombre, String apellido, String telefono, String direccion, int dni) : base(nombre, apellido, telefono, direccion, dni)
        {
            mascotas = new List<Mascota>();
        }
        public void AgregarMascota(Mascota mascota)
        {
            mascotas.Add(mascota);
        }
    }
}

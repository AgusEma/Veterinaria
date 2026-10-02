using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Turno
    {
        public int idTurno { get; set; }
        public DateTime fechaTurno { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public Veterinario veterinario { get; set; }
        public Cliente cliente { get; set; }
        public Mascota mascota { get; set; }
        public bool asistencia { get; set; }
        public String motivo { get; set; }

        public Turno(int idTurno, DateTime fechaTurno, DateTime fechaSolicitud, Veterinario veterinario, Cliente cliente, Mascota mascota, bool asistencia, String motivo)
        {
            this.idTurno = idTurno;
            this.fechaTurno = fechaTurno;
            this.fechaSolicitud = fechaSolicitud;
            this.veterinario = veterinario;
            this.cliente = cliente;
            this.mascota = mascota;
            this.asistencia = asistencia;
            this.motivo = motivo;
        }
    }
}

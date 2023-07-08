using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Prestamos = new HashSet<Prestamo>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}

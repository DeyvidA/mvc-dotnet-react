using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public int? IdLibro { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaReserva { get; set; }
        public string EstadoReserva { get; set; }

        public virtual Libro IdLibroNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

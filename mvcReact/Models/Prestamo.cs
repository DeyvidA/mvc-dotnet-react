using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Prestamo
    {
        public Prestamo()
        {
            Multa = new HashSet<Multa>();
        }

        public int IdPrestamo { get; set; }
        public int? IdLibro { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaDevolucionPrevista { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }

        public virtual Libro IdLibroNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Multa> Multa { get; set; }
    }
}

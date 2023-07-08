using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Multa
    {
        public int IdMulta { get; set; }
        public int? IdPrestamo { get; set; }
        public decimal? MontoMulta { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public string EstadoMulta { get; set; }

        public virtual Prestamo IdPrestamoNavigation { get; set; }
    }
}

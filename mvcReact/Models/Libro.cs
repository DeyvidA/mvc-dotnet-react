using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Libro
    {
        public Libro()
        {
            Prestamos = new HashSet<Prestamo>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int? AnioPublicacion { get; set; }
        public string Categoria { get; set; }
        public string Isbn { get; set; }
        public string Descripcion { get; set; }
        public int? CopiasDisponibles { get; set; }
        public string Ubicacion { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}

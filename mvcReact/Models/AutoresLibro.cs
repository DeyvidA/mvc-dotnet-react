using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class AutoresLibro
    {
        public int? IdAutor { get; set; }
        public int? IdLibro { get; set; }

        public virtual Autore IdAutorNavigation { get; set; }
        public virtual Libro IdLibroNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class CategoriasLibro
    {
        public int? IdCategoria { get; set; }
        public int? IdLibro { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Libro IdLibroNavigation { get; set; }
    }
}

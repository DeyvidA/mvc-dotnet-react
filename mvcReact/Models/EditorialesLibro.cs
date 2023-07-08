using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class EditorialesLibro
    {
        public int? IdEditorial { get; set; }
        public int? IdLibro { get; set; }

        public virtual Editoriale IdEditorialNavigation { get; set; }
        public virtual Libro IdLibroNavigation { get; set; }
    }
}

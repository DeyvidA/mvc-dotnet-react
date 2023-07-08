using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Editoriale
    {
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string SitioWeb { get; set; }
    }
}

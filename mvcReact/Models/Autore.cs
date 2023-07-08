using System;
using System.Collections.Generic;

#nullable disable

namespace mvcReact.Models
{
    public partial class Autore
    {
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Biografia { get; set; }
    }
}

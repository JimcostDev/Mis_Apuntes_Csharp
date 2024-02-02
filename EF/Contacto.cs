using System;
using System.Collections.Generic;

namespace EF
{
    public partial class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; }
        public string Telefono { get; set; } = null!;
        public string? Correo { get; set; }
    }
}

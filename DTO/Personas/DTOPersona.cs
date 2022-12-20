using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Personas
{
    public class DTOPersona
    {
        public int? Identificador { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? NumeroIdentificacion { get; set; }
        public string? Email { get; set; }
        public string? TipoIdentificacion { get; set; }
        public DateTime? FechaDeCreacion { get; set; }

        public string? TipoConIdentificacion { get; set; }
        public string? NombreCompleto { get; set; }
        public int  Estado { get; set; }
    }
}

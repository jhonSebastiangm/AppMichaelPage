using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Login
{
    public class DTOLogin
    {
        public int? Identificador { get; set; }
        public string Usuario { get; set; } 
        public string pass { get; set; }
        public DateTime FechaDeCreacion { get; set; }     

    }
}

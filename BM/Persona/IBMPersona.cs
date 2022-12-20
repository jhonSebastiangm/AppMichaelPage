using DTO.Mensajes;
using DTO.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Persona
{
    public interface IBMPersona
    {
        DTORespuesta<IList<DTOPersona>> consultarPersonas();
        DTORespuesta<IList<DTOPersona>> consultarPersona(int persona);
        DTORespuesta<DTOPersona> crearPersona(DTOPersona persona);
        DTORespuesta<DTOPersona> actualizarPersona(DTOPersona persona);
    }
}

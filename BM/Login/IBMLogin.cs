using DTO.Login;
using DTO.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Login
{
    public interface IBMLogin
    {
        DTORespuesta<IList<DTOLogin>> ConsultarLogin(DTOLogin login);
    }
}

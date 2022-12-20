using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Mensajes
{
    public class DTORespuesta<T>
    {
        public T Data { get; set; }
        public DTOMensaje Mensaje { get; set; }
    }
}

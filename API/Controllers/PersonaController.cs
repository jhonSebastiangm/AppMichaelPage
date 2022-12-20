using BM.Persona;
using DTO.Mensajes;
using DTO.Personas;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/Persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        public IBMPersona objPersona;

        public PersonaController(IBMPersona Ipersona)
        {
            objPersona = Ipersona;
        }

        [HttpGet]
        [Route("consultarPersonas")]
        public ActionResult<DTORespuesta<IList<DTOPersona>>> consultar()
        {
            DTORespuesta<IList<DTOPersona>> respuesta = new DTORespuesta<IList<DTOPersona>>();
            respuesta = objPersona.consultarPersonas();
            return respuesta;
        }

        [HttpGet("{identificador}")]
        public ActionResult<DTORespuesta<IList<DTOPersona>>> consultarIdentificador(int identificador)
        {
            DTORespuesta<IList<DTOPersona>> respuesta = new DTORespuesta<IList<DTOPersona>>();
            respuesta = objPersona.consultarPersona(identificador);
            return respuesta;
        }
        [HttpPost]
        [Route("crearPersona")]
        public ActionResult<DTORespuesta<DTOPersona>> crearPersona(DTOPersona persona)
            {
            DTORespuesta<DTOPersona> respuesta = new DTORespuesta<DTOPersona>();
            respuesta = objPersona.crearPersona(persona);
            return respuesta;
        }

        [HttpPut]
        [Route("actualizarPersona")]
        public ActionResult<DTORespuesta<DTOPersona>> actualizarPersona(DTOPersona persona)
        {
            DTORespuesta<DTOPersona> respuesta = new DTORespuesta<DTOPersona>();
            respuesta = objPersona.actualizarPersona(persona);
            return respuesta;
        }
    }
    
}

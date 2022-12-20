using BM.Login;
using DTO.Login;
using DTO.Mensajes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/Login")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        private IBMLogin objLogin;

        public LoginController(IBMLogin Ilogin) 
        {
            objLogin = Ilogin;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<DTORespuesta<IList<DTOLogin>>> ConsultarLogin(DTOLogin login)
        {
            DTORespuesta<IList<DTOLogin>> respuesta = new DTORespuesta<IList<DTOLogin>>();
            respuesta = objLogin.ConsultarLogin(login);
            return respuesta;
        }

    }
}

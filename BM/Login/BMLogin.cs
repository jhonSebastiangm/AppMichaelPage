using DM.AccesoDM;
using DTO.Login;
using DTO.Mensajes;
using Microsoft.Extensions.Configuration;
using SOPORTE.Recursos;

namespace BM.Login
{
    public class BMLogin : IBMLogin
    {
        private readonly IConfiguration _configuration;

        public BMLogin(IConfiguration configuration) 
        {
            _configuration = configuration;
        }


        public DTORespuesta<IList<DTOLogin>> ConsultarLogin(DTOLogin login)
        {
            DTORespuesta<IList<DTOLogin>> respuesta = new DTORespuesta<IList<DTOLogin>>();
            DTOMensaje mensaje = new DTOMensaje();

            try
            {
                DTOLogin dTOLogin = new DTOLogin();
                string conexion = _configuration.GetConnectionString("DefaultConnection");
                IList<DTOLogin> dTOLogins = new DMAcceso<DTOLogin>().ConsultarList(Recursos.consultarUsuario,login,conexion);

                if (dTOLogins.Count > 0)
                {
                    mensaje.Mensaje = "";
                    respuesta.Data = dTOLogins;
                    respuesta.Mensaje = mensaje;
                }
                else
                {
                    mensaje.Mensaje = Mensajes.errorLogin;
                    mensaje.Error = true;
                    respuesta.Data = null;
                    respuesta.Mensaje = mensaje;
                }
            }
            catch (Exception)
            {

                mensaje.Mensaje = Mensajes.exception;
                mensaje.Error = true;
                respuesta.Data= null;
                respuesta.Mensaje = mensaje;
            }
            return respuesta;
        }
    }

    
}

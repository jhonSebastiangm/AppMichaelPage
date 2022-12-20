using DM.AccesoDM;
using DTO.Mensajes;
using DTO.Personas;
using Microsoft.Extensions.Configuration;
using SOPORTE.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Persona
{
    public class BMPersona : IBMPersona
    {
        private readonly IConfiguration _configuration;

        public BMPersona(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DTORespuesta<DTOPersona> actualizarPersona(DTOPersona persona)
        {
            DTORespuesta<DTOPersona> respuesta = new DTORespuesta<DTOPersona>();
            DTOMensaje mensaje = new DTOMensaje();
            try
            {
                DTOPersona dtPersona = new DTOPersona();
                persona.NombreCompleto = persona.Nombres + " " + persona.Apellidos;
                persona.TipoConIdentificacion = persona.TipoIdentificacion + persona.NumeroIdentificacion;
     
                string conexion = _configuration.GetConnectionString("DefaultConnection");
                dtPersona = new DMAcceso<DTOPersona>().Operar(Recursos.actualizarPersona, persona, conexion);
                mensaje.Mensaje = Mensajes.update;
                respuesta.Data = null;
                respuesta.Mensaje = mensaje;
            }
            catch (Exception)
            {
                mensaje.Mensaje = Mensajes.exception2;
                mensaje.Error = true;
                respuesta.Data = null;
                respuesta.Mensaje = mensaje;
            }
            return respuesta;
        }

        public DTORespuesta<IList<DTOPersona>> consultarPersonas()
        {
            DTORespuesta<IList<DTOPersona>> respuesta = new DTORespuesta<IList<DTOPersona>>();
            DTOMensaje mensaje = new DTOMensaje();
            try
            {
                DTOPersona dtPersona = new DTOPersona();
                
                string conexion = _configuration.GetConnectionString("DefaultConnection");
                IList<DTOPersona> dtPersonas = new DMAcceso<DTOPersona>().ConsultarList(Recursos.consultarPersonas, dtPersona, conexion);


                if (dtPersonas.Count > 0)
                {
                    mensaje.Mensaje = "";
                    respuesta.Data = dtPersonas;
                    respuesta.Mensaje = mensaje;
                }
                else
                {
                    mensaje.Mensaje = Mensajes.errorGet;
                    mensaje.Error = true;
                    respuesta.Data = null;
                    respuesta.Mensaje = mensaje;
                }

            }
            catch (Exception)
            {
                mensaje.Mensaje = Mensajes.exception2;
                mensaje.Error = true;
                respuesta.Data = null;
                respuesta.Mensaje = mensaje;
            }

            return respuesta;
        }


        public DTORespuesta<DTOPersona> crearPersona(DTOPersona persona)
        {
            DTORespuesta<DTOPersona> respuesta = new DTORespuesta<DTOPersona>();
            DTOMensaje mensaje = new DTOMensaje();
            try
            {
                DTOPersona dtPersona = new DTOPersona();
                persona.NombreCompleto = persona.Nombres + " " + persona.Apellidos;
                persona.TipoConIdentificacion = persona.TipoIdentificacion + persona.NumeroIdentificacion;
                string conexion = _configuration.GetConnectionString("DefaultConnection");
                dtPersona = new DMAcceso<DTOPersona>().Operar(Recursos.crearPersona, persona, conexion);

                if (dtPersona.Identificador != null)
                {
                    mensaje.Mensaje = Mensajes.create;
                    respuesta.Data = dtPersona;
                    respuesta.Mensaje = mensaje;
                }
                else
                {
                    mensaje.Mensaje = Mensajes.errorCreate;
                    mensaje.Error = true;
                    respuesta.Data = null;
                    respuesta.Mensaje = mensaje;

                }
            }
            catch (Exception)
            {
                mensaje.Mensaje = Mensajes.exception;
                mensaje.Error = true;
                respuesta.Data = null;
                respuesta.Mensaje = mensaje;
            }
            return respuesta;
        }

        public DTORespuesta<IList<DTOPersona>> consultarPersona(int dtPersona)
        {
            DTORespuesta<IList<DTOPersona>> respuesta = new DTORespuesta<IList<DTOPersona>>();
            DTOMensaje mensaje = new DTOMensaje();
            try
            {
                DTOPersona persona= new DTOPersona();
                persona.Identificador = dtPersona;

                string conexion = _configuration.GetConnectionString("DefaultConnection");
                IList<DTOPersona> dtPersonas = new DMAcceso<DTOPersona>().ConsultarList(Recursos.consultarPersonasId, persona, conexion);


                if (dtPersonas.Count > 0)
                {
                    mensaje.Mensaje = "";
                    respuesta.Data = dtPersonas;
                    respuesta.Mensaje = mensaje;
                }
                else
                {
                    mensaje.Mensaje = Mensajes.errorGet;
                    mensaje.Error = true;
                    respuesta.Data = null;
                    respuesta.Mensaje = mensaje;
                }

            }
            catch (Exception)
            {
                mensaje.Mensaje = Mensajes.exception2;
                mensaje.Error = true;
                respuesta.Data = null;
                respuesta.Mensaje = mensaje;
            }

            return respuesta;
        }


    }
}

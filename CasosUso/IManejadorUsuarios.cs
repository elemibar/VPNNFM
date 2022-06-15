using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorUsuarios
    {

        
        bool Login(string nombreUsuario, string contrasenia);
        
    }
}
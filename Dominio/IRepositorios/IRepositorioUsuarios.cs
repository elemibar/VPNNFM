using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.IRepositorios
{


    public interface IRepositorioUsuarios : IRepositorio<Usuario>
    {

        Usuario getByUsername(string username);

        bool login(string username, string password);

    }


}
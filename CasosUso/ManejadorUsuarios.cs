using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;

namespace CasosUso
{
    public class ManejadorUsuarios : IManejadorUsuarios
    {

        public IRepositorioUsuarios RepoUsuarios { get; set; }

        public ManejadorUsuarios(IRepositorioUsuarios repoUsuarios)
        {

            RepoUsuarios = repoUsuarios;

        }

        public bool Login(string username, string password)
        {

            return RepoUsuarios.login(username, password);
            
        }


    }

}
using System;
using System.Collections.Generic;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;
using Novell.Directory.Ldap;

namespace Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        public bool Add(Usuario obj)
        {

            throw new NotImplementedException();
 
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario getByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool login(string username, string password)
        {
            
            bool ret = false;

            // Restriccion para que solo inicien sesion ciertos usuarios de ATIC 
            if(username=="emilio.barcelona"||username=="mitchel.quilici"||username=="andrea.carrion"||username=="patricia.bentancur")
            {

                
                string server = "10.1.1.25";
                string userDn = $"uid={username},ou=users,dc=imcanelones,dc=gub,dc=uy";
                
                try
                {
                    using(LdapConnection connection = new LdapConnection{SecureSocketLayer = false})
                    {
                        
                        connection.Connect(server, LdapConnection.DefaultPort);

                        connection.Bind(LdapConnection.LdapV3, userDn, password);
                        
                        if(connection.Bound)
                        {
                            ret = true; 
                        }

                    }
                }
                catch (LdapException ex)
                {
                    ret = false;
                }

            }
            return ret;
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
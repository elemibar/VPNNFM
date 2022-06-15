using System;
using System.Collections.Generic;
using System.Text;
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
            string dominio = "imcanelones.gub.uy";
            //string server = "ldap://10.1.1.25";
            string userDn = $"cn={username},dc=imcanelones,dc=gub,dc=uy";
            System.Console.WriteLine("-->DN:" + userDn);
            System.Console.WriteLine("-->" + password);
            try
            {
                using(LdapConnection connection = new LdapConnection{SecureSocketLayer = false})
                {
                    connection.Connect(dominio, LdapConnection.DefaultPort);
                    connection.Bind(userDn, "");
                        System.Console.WriteLine(connection.Bound);
                    if(connection.Bound)
                    {
                        return true;
                    }

                }
            }
            catch (LdapException ex)
            {
                throw ex;
                //System.Console.WriteLine("LDAP exception: " + ex.LdapErrorMessage);
            }
            
            return false;
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
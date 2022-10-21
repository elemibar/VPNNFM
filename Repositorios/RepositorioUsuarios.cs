using System;
using System.Collections.Generic;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;
using Novell.Directory.Ldap;
using Novell.Directory.Ldap.Utilclass;
using System.ComponentModel;

using System.IO;//.FileStream;

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

            // Restriccion (HARDCODED) para que solo inicien sesion ciertos usuarios de ATIC

            if(getUserGroups(username))
            {
                
/*          if(username=="emilio.barcelona"||username=="mitchel.quilici"||username=="andrea.carrion"
                ||username=="patricia.bentancur" || username=="lisandro.legniani")
            {*/

                /*
                string server = "10.1.1.25";
                string baseDn = "dc=imcanelones,dc=gub,dc=uy";*/
                string usersDn = Conexion.ObtenerStringUsersDnLDAP();
                string userDn = "";
                

                //Formato user dn
                //string userDn = $"uid={username},ou=users,dc=imcanelones,dc=gub,dc=uy";

                try
                {
                    using(LdapConnection connection = Conexion.ObtenerConexionLDAP())
                    {
                        
                        Conexion.AbrirConexionBD(connection);

                        /* Retornar el DN del usuario para poder hacer bind con usuarios del subtree de Users */
                        userDn = GetUserDN(connection, usersDn, username);


                        connection.Bind(LdapConnection.LdapV3, userDn, password);
                        
                        if(connection.Bound)
                        {
                            ret = true; 
                        }

                    }
                }
                catch (LdapException ex)
                {
                    System.Console.WriteLine("LDAP exception: " + ex);
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

        private string GetUserDN(LdapConnection connection, string searchBase, string user)
        {
            
            
            string retDn = "";
            
            try
            {
    
                var constraints = new LdapSearchConstraints();
                constraints.SetControls(new LdapControl[]{});

                ILdapSearchResults searchResults = connection.Search(
                    searchBase,
                    LdapConnection.ScopeSub,
                    $"(uid={user})",
                    null,
                    false,
                    constraints
                );


                if (searchResults != null && searchResults.HasMore())//&& ((cntTotal == null) || (cntRead < cntTotal)))
                {
                                                
                    //LdapEntry result = searchResults.Next();

                    try
                    {
                        LdapEntry entry = searchResults.Next();
                        System.Console.WriteLine("DN: " + entry.Dn);
                        retDn = entry.Dn;
                            
                    }
                    catch (LdapReferralException ex)
                    {
                        System.Console.WriteLine("Ldap exception: " + ex);
                    }
                }    
                
            }
            catch (LdapException ex)
            {
                System.Console.WriteLine("Ldap exception: " + ex);
            }
            


            return retDn;   
        }

        public bool getUserGroups(string username)
        {
            bool ret = false;

            try
            {
                FileStream fileStream = new FileStream("groups", FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        if(!ret)ret = line.StartsWith(username);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File read exception: " + ex);
            }


            return ret;

        }


    }
}
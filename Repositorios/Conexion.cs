using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Novell.Directory.Ldap;
using Novell.Directory.Ldap.Utilclass;

namespace Repositorios
{
    public class Conexion
    {
        
        /* ############## CONEXION BD ################ */

        public static string ObtenerStringConexionBD()
        {
            string stringConexion = "";

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            stringConexion = configuracion.GetConnectionString("ConexionBD");

            return stringConexion;
        }

        public static NpgsqlConnection ObtenerConexionBD()
        {
            string strCon = ObtenerStringConexionBD();
            return new NpgsqlConnection(strCon);
        }

        public static void AbrirConexionBD(NpgsqlConnection con)
        {
            if (con != null && con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public static void CerrarYDisposeConexionDB(NpgsqlConnection con)
        {
            CerrarConexionBD(con);
            con.Dispose();
        }

        public static void CerrarConexionBD(NpgsqlConnection con)
        {
            if(con != null && con.State != System.Data.ConnectionState.Closed)
                    con.Close();
        }

        /* ########################################### */

        /* ############# CONEXION LDAP ############### */

        /* ------------ Obtener variables ------------ */
        public static string ObtenerStringConexionLDAP()
        {
            string stringConexion = "";

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            stringConexion = configuracion.GetSection("ConexionLDAP:server").Value;

            return stringConexion;
        }

        public static string ObtenerStringBaseBDLDAP()
        {
            string strBaseDn = "";

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            strBaseDn = configuracion.GetSection("ConexionLDAP:baseDn").Value;

            return strBaseDn;
        } 

        public static int ObtenerIntPuertoLDAP()
        {
            int puerto = LdapConnection.DefaultPort;

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            //Int.TryParse(configuracion.GetSection("ConexionLDAP:puerto").Value, puerto);
            if(!int.TryParse(configuracion.GetSection("ConexionLDAP:puerto").Value, out puerto) || puerto == 0)
                 puerto = LdapConnection.DefaultPort;

            return puerto;
        } 

        public static string ObtenerStringUsersOULDAP()
        {
            string uou = "";

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            uou = configuracion.GetSection("ConexionLDAP:usersOu").Value;
            
            return uou;
        }

        public static string ObtenerStringUsersDnLDAP()
        {
            string udn = "";

            ConfigurationBuilder cb = new ConfigurationBuilder();
            cb.AddJsonFile("appsettings.json");
            IConfiguration configuracion = cb.Build();

            udn = configuracion.GetSection("ConexionLDAP:usersOu").Value + "," + configuracion.GetSection("ConexionLDAP:baseDn").Value;
            
            return udn;
        }

        /* --------------------------------------------- */

        /* -------------- Manejar Conexion ------------- */

        public static LdapConnection ObtenerConexionLDAP()
        {
            return new LdapConnection{SecureSocketLayer = false};
        }

        public static void AbrirConexionBD(LdapConnection con)
        {
            
            if (con != null)
            {
                con.Connect(Conexion.ObtenerStringConexionLDAP(), Conexion.ObtenerIntPuertoLDAP());
            }

        }


        /* NI
        public static void CerrarYDisposeConexionLDAP(LdapConnection con)
        {
            CerrarConexionLDAP(con);
            con.Dispose();
        }

        public static void CerrarConexionLDAP(LdapConnection con)
        {
            if(con != null && con.State != System.Data.ConnectionState.Closed)
                    con.Close();
        }
        */

        /* --------------------------------------------- */

    }
}
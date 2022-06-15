using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Globalization;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;
using Npgsql;
using NpgsqlTypes;

namespace Repositorios
{
    public class RepositorioVPNs : IRepositorioVPNs
    {

        public bool Add(VPN obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {

            throw new NotImplementedException();

        }

        public bool Update(VPN obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VPN> FindAll()
        {
            List<VPN> TodasVPNs = new List<VPN>();

            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "SELECT * FROM vpn WHERE ip::text LIKE '192.168.%'";
            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);
           
            
            try 
            {

                conn.Open();
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    VPN nuevaVPN = new VPN();
                    
                        if(!reader.IsDBNull(0))nuevaVPN.Ip = reader.GetFieldValue<IPAddress>(0);
                        if(!reader.IsDBNull(1))nuevaVPN.Usuario = reader.GetString(1);
                        if(!reader.IsDBNull(2))nuevaVPN.Nombre = reader.GetString(2);
                        if(!reader.IsDBNull(3))nuevaVPN.Dependencia = reader.GetString(3);
                        if(!reader.IsDBNull(4))nuevaVPN.Direccion = reader.GetString(4);
                        if(!reader.IsDBNull(5))nuevaVPN.Gabinete = reader.GetString(5);
                        if(!reader.IsDBNull(6))nuevaVPN.Alta = reader.GetDateTime(6);
                        if(!reader.IsDBNull(7))nuevaVPN.Baja = reader.GetDateTime(7);
                        if(reader.GetFieldValue<IPAddress>(0).ToString().StartsWith("192.168."))nuevaVPN.Tipo = (VPN.EnumTipo)1; else nuevaVPN.Tipo = (VPN.EnumTipo)2;

                    

                    TodasVPNs.Add(nuevaVPN);
                }
                
            }
            catch(NpgsqlException ex)
            {
                 //if(conn.State != ConnectionState.Closed)
                    //conn.Close();
                
                    //conn.Dispose();
                //throw;
                System.Console.WriteLine(ex);
            }
            finally
            {
                //if(conn.State != ConnectionState.Closed)
                    conn.Close();
                
                    conn.Dispose();
                
            }

            return TodasVPNs;
        }

        public VPN FindById(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<VPN> findActiveVPNsOnDates(DateTime start, DateTime end)
        {

            
            throw new NotImplementedException();



        }
        

        public IEnumerable<VPN> findVPN(List<string> IPs, string nombre, DateTime? alta, DateTime? baja, VPN.EnumTipo tipo)
        {

            List<VPN> TodasVPNs = new List<VPN>();

            List<IPAddress> IPAddrs = new List<IPAddress>();
            string paramStringIp = "";
            string paramNombre = nombre;
            string paramAlta = "-infinity"; //inicio
            string paramBaja = "infinity"; //fin
            string paramTipo = "";

            if(IPs != null && IPs.Count > 0)
            {
                foreach(string ipstr in IPs)
                {
                    IPAddrs.Add(IPAddress.Parse(ipstr));
                }
            }
                     

            if(alta != null)
            {
                paramAlta = alta.ToString();
            }
            
            if(baja != null)
            {
                paramBaja = baja.ToString();
            }
                  /*      
            if(tipo.GetHashCode()!=0)
            {
                if(tipo.GetHashCode()==1)
                {
                    paramTipo = "192.168.";
                }
                else if(tipo.GetHashCode()==2)
                {
                    paramTipo = "10.1.";
                }

            }
             ESTO ES POR LA INCONSISTENCIA DE LOS DATOS */  
            paramTipo = "192.168.";


            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "SELECT * FROM vpn ";
                                if(IPs != null && IPs.Count > 0)
                                        //strSql += "WHERE (ip=(@paramIp)) ";
                                        strSql += "WHERE (ip = ANY(@paramLIp)) ";
                                    else
                                    {
                                        strSql += "WHERE (ip::text LIKE (@paramStringIp)) ";
                                    }
                               strSql += "(ip::text LIKE (@paramTipo)) AND ";
            if(nombre != null && nombre.Length > 0)
                strSql += "(nombre LIKE (@paramNombre)) AND ";
            else
                strSql += "( (nombre LIKE (@paramNombre)) OR (nombre IS NULL) ) AND ";

            strSql += "((alta <= (@paramBaja)::timestamp OR alta IS NULL) AND " +
                                "(baja >= (@paramAlta)::timestamp OR baja IS NULL))";


            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);

            if(IPs != null && IPs.Count > 0)
                //cmd.Parameters.AddWithValue("paramIp", paramIp);
                cmd.Parameters.Add("@paramLIp", NpgsqlDbType.Array|NpgsqlDbType.Inet).Value = IPAddrs;
            else
                cmd.Parameters.AddWithValue("paramStringIp", "%"+paramStringIp+"%");
            cmd.Parameters.AddWithValue("paramTipo", "%"+paramTipo+"%");
            cmd.Parameters.AddWithValue("paramNombre", "%"+paramNombre+"%");
            cmd.Parameters.AddWithValue("paramBaja", paramBaja);
            cmd.Parameters.AddWithValue("paramAlta", paramAlta);
            
            
            try 
            {

                conn.Open();
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    VPN nuevaVPN = new VPN();
                    
                        if(!reader.IsDBNull(0))nuevaVPN.Ip = reader.GetFieldValue<IPAddress>(0);
                        if(!reader.IsDBNull(1))nuevaVPN.Usuario = reader.GetString(1);
                        if(!reader.IsDBNull(2))nuevaVPN.Nombre = reader.GetString(2);
                        if(!reader.IsDBNull(3))nuevaVPN.Dependencia = reader.GetString(3);
                        if(!reader.IsDBNull(4))nuevaVPN.Direccion = reader.GetString(4);
                        if(!reader.IsDBNull(5))nuevaVPN.Gabinete = reader.GetString(5);
                        if(!reader.IsDBNull(6))nuevaVPN.Alta = reader.GetDateTime(6);
                        if(!reader.IsDBNull(7))nuevaVPN.Baja = reader.GetDateTime(7);
                        if(reader.GetFieldValue<IPAddress>(0).ToString().StartsWith("192.168."))nuevaVPN.Tipo = (VPN.EnumTipo)1; else nuevaVPN.Tipo = (VPN.EnumTipo)2;

                    

                    TodasVPNs.Add(nuevaVPN);
                }
                
            }
            catch(NpgsqlException ex)
            {
                 //if(conn.State != ConnectionState.Closed)
                    //conn.Close();
                
                    //conn.Dispose();
                //throw;
                System.Console.WriteLine(ex);
            }
            finally
            {
                //if(conn.State != ConnectionState.Closed)
                    conn.Close();
                
                    conn.Dispose();
                
            }

            return TodasVPNs;


        }


    }
}
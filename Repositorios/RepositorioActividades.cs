using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;
using Npgsql;
using NpgsqlTypes;

namespace Repositorios
{
    public class RepositorioActividades : IRepositorioActividades
    {

        public bool Add(Actividad obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {

            throw new NotImplementedException();

        }

        public bool Update(Actividad obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actividad> FindAll()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<VPN> FindAllAVPN()
        {
            
            List<VPN> TodasActividadesPorVPN = new List<VPN>();

            System.Console.WriteLine("RepoAct findallAVPN");

            /* MOVER A CLASE CONECTIONHANDLER */
            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "SELECT v.*, a.* " +
                            "FROM vpn v, actividad a " +
                            "WHERE (v.ip = a.ip) AND " +
                            "(a.ip::text LIKE '192.168.%') AND " + // Este filtro esta aplicado por la insconsistencia de los datos
                            "(((a.inicio >= v.alta)OR(v.alta IS NULL)) AND ((a.fin <= v.baja)OR(v.baja IS NULL))) " +
                            "ORDER BY v.ip";


            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);
            
            try 
            {

                conn.Open();
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                VPN nuevaVPN = new VPN();
                Actividad nuevaActividad = new Actividad();
                VPN ultimaVPN = new VPN();

                nuevaVPN.Actividades = new List<Actividad>();
                ultimaVPN.Actividades = new List<Actividad>();

                while(reader.Read())
                {
                                      
                        
                        if(!reader.IsDBNull(0))nuevaVPN.Ip = reader.GetFieldValue<IPAddress>(0);
                        if(!reader.IsDBNull(1))nuevaVPN.Usuario = reader.GetString(1);
                        if(!reader.IsDBNull(2))nuevaVPN.Nombre = reader.GetString(2);
                        if(!reader.IsDBNull(3))nuevaVPN.Dependencia = reader.GetString(3);
                        if(!reader.IsDBNull(4))nuevaVPN.Direccion = reader.GetString(4);
                        if(!reader.IsDBNull(5))nuevaVPN.Gabinete = reader.GetString(5);
                        if(!reader.IsDBNull(6))nuevaVPN.Alta = reader.GetDateTime(6);
                        if(!reader.IsDBNull(7))nuevaVPN.Baja = reader.GetDateTime(7);
                        if(reader.GetFieldValue<IPAddress>(0).ToString().StartsWith("192.168."))nuevaVPN.Tipo = (VPN.EnumTipo)1; else nuevaVPN.Tipo = (VPN.EnumTipo)2;

                        if(!reader.IsDBNull(8))nuevaActividad.Ip = reader.GetFieldValue<IPAddress>(8);
                        if(!reader.IsDBNull(9))nuevaActividad.Inicio = reader.GetDateTime(9);
                        if(!reader.IsDBNull(10))nuevaActividad.Fin = reader.GetDateTime(10);
                        if(!reader.IsDBNull(11))nuevaActividad.Segundos = reader.GetInt32(11);
                        if(!reader.IsDBNull(12))nuevaActividad.Destino = reader.GetFieldValue<IPAddress>(12);
                        if(!reader.IsDBNull(13))nuevaActividad.Protocolo = reader.GetString(13);
                        if(!reader.IsDBNull(14))nuevaActividad.Puerto = reader.GetInt32(14);
                        if(!reader.IsDBNull(15))nuevaActividad.Bytesh = reader.GetString(15);
                        //if(!reader.IsDBNull(16))nuevaActividad.Bytes = reader.GetInt32(16);

                    if(!(ultimaVPN.Ip == nuevaVPN.Ip && ultimaVPN.Alta == nuevaVPN.Alta && ultimaVPN.Baja == nuevaVPN.Baja))
                    {
                        System.Console.WriteLine("nueva");
                        ultimaVPN = nuevaVPN;
                        nuevaVPN = new VPN();
                        nuevaVPN.Actividades = new List<Actividad>();
                        TodasActividadesPorVPN.Add(ultimaVPN);

                    }

                    ultimaVPN.Actividades.Add(nuevaActividad);
                    
                }
                
            }
            catch(NpgsqlException ex)
            {
                 if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                    conn.Dispose();
                //throw;
                System.Console.WriteLine(ex);
            }
            finally
            {
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                    conn.Dispose();
                
            }

            return TodasActividadesPorVPN;
        }

        public Actividad FindById(int id)
        {
            throw new NotImplementedException();
        }
       
        public IEnumerable<VPN> findActividad(List<string> IPs, string inicio, string fin)
        {
            List<VPN> TodasActividadesPorVPN = new List<VPN>();      
            
            List<IPAddress> IPaddrs = new List<IPAddress>();
            string paramStringIp = "";
            string paramInicio = "-infinity"; //inicio
            string paramFin = "infinity"; //fin

            if(IPs != null && IPs.Count > 0)
            {
                foreach(string ipstring in IPs)
                {
                    System.Console.WriteLine("IPString: " + ipstring);
                    if(ipstring!=null && ipstring.Length>0) IPaddrs.Add(IPAddress.Parse(ipstring));
                }
                
            }
         
            
            if(inicio != null && inicio != "1/1/0001 00:00:00" && inicio != "")
            {
                paramInicio = inicio;
            }
            
            if(fin != null && fin != "1/1/0001 00:00:00" && fin != "")
            {
                paramFin = fin;
            }
            
            /* MOVER A CLASE CONECTIONHANDLER */
            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "SELECT v.*, a.* " +
                            "FROM (SELECT ip, usuario, nombre, dependencia, direccion, gabinete, alta, baja " +
                                    "FROM vpn ";
                                    if(IPaddrs != null && IPaddrs.Count > 0)
                                        //strSql += "WHERE (ip=(@paramIp)) ";
                                        strSql += "WHERE (ip = ANY(@paramLIp)) ";
                                    else
                                    {
                                        strSql += "WHERE (ip::text LIKE (@paramStringIp)) ";
                                    }
                                        strSql += "AND (ip::text LIKE '192.168.%') " + // Este filtro esta aplicado por la insconsistencia de los datos
                                                  "AND ((alta <= (@paramFin)::timestamp OR alta IS NULL) " +
                                                    "AND (baja >= (@paramInicio)::timestamp OR baja IS NULL))) v, actividad a " +
                            "WHERE (v.ip = a.ip) " +
                                "AND ((a.inicio >= (@paramInicio)::timestamp) " + 
                                    "AND (a.fin <= (@paramFin)::timestamp)) " +
                                "AND (((a.inicio >= v.alta)OR(v.alta IS NULL)) " +
                                    "AND ((a.fin <= v.baja)OR(v.baja IS NULL))) " +
                            "ORDER BY v.ip";


            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);

                System.Console.WriteLine("Addrs: " + IPaddrs.Count);
                System.Console.WriteLine("Strings: " + IPs.Count);
            if(IPaddrs != null && IPaddrs.Count > 0)
                {cmd.Parameters.Add("@paramLIp", NpgsqlDbType.Array|NpgsqlDbType.Inet).Value = IPaddrs.ToArray();
                
                } 
            else
                {cmd.Parameters.AddWithValue("paramStringIp", "%"+paramStringIp+"%");} 
            cmd.Parameters.AddWithValue("paramFin", paramFin);
            
            cmd.Parameters.AddWithValue("paramInicio", paramInicio);
            
            
            

            try 
            {

                conn.Open();
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                
                
                VPN ultimaVPN = new VPN();
                ultimaVPN.Actividades = new List<Actividad>();

                while(reader.Read())
                {
                                      
                        VPN nuevaVPN = new VPN();
                        nuevaVPN.Actividades = new List<Actividad>();
                        Actividad nuevaActividad = new Actividad();

                        if(!reader.IsDBNull(0))nuevaVPN.Ip = reader.GetFieldValue<IPAddress>(0);
                        if(!reader.IsDBNull(1))nuevaVPN.Usuario = reader.GetString(1);
                        if(!reader.IsDBNull(2))nuevaVPN.Nombre = reader.GetString(2);
                        if(!reader.IsDBNull(3))nuevaVPN.Dependencia = reader.GetString(3);
                        if(!reader.IsDBNull(4))nuevaVPN.Direccion = reader.GetString(4);
                        if(!reader.IsDBNull(5))nuevaVPN.Gabinete = reader.GetString(5);
                        if(!reader.IsDBNull(6))nuevaVPN.Alta = reader.GetDateTime(6);
                        if(!reader.IsDBNull(7))nuevaVPN.Baja = reader.GetDateTime(7);
                        if(reader.GetFieldValue<IPAddress>(0).ToString().StartsWith("192.168."))nuevaVPN.Tipo = (VPN.EnumTipo)1; else nuevaVPN.Tipo = (VPN.EnumTipo)2;

                        if(!reader.IsDBNull(8))nuevaActividad.Ip = reader.GetFieldValue<IPAddress>(8);
                        if(!reader.IsDBNull(9))nuevaActividad.Inicio = reader.GetDateTime(9);
                        if(!reader.IsDBNull(10))nuevaActividad.Fin = reader.GetDateTime(10);
                        if(!reader.IsDBNull(11))nuevaActividad.Segundos = reader.GetInt32(11);
                        if(!reader.IsDBNull(12))nuevaActividad.Destino = reader.GetFieldValue<IPAddress>(12);
                        if(!reader.IsDBNull(13))nuevaActividad.Protocolo = reader.GetString(13);
                        if(!reader.IsDBNull(14))nuevaActividad.Puerto = reader.GetInt32(14);
                        if(!reader.IsDBNull(15))nuevaActividad.Bytesh = reader.GetString(15);
                        if(!reader.IsDBNull(16))nuevaActividad.Bytes = reader.GetInt64(16);

                    if(nuevaVPN.Equals(ultimaVPN))
                    {

                        ultimaVPN.Actividades.Add(nuevaActividad);

                    }
                    else
                    {
                        ultimaVPN = nuevaVPN;
                        ultimaVPN.Actividades.Add(nuevaActividad);
                        TodasActividadesPorVPN.Add(ultimaVPN);
                    }

                    
                }
                
            }
            catch(NpgsqlException ex)
            {
                 if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                    conn.Dispose();
                //throw;
                System.Console.WriteLine(ex);
            }
            finally
            {
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                    conn.Dispose();
                
            }

            //System.Console.WriteLine("RepoAct findAct ret: " + TodasActividadesPorVPN.Count);
            //System.Console.WriteLine("RepoAct findAct ret: " + TodasActividadesPorVPN[0].Actividades.Count);
            return TodasActividadesPorVPN;

        }

    }
}
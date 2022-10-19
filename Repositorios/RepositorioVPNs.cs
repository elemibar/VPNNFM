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
        //NI
        public bool Add(VPN obj)
        {
            bool ret = false;
            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "";
            


            if(obj.Baja != null && obj.Baja != DateTime.Parse("1/1/0001 00:00:00"))
            {
                strSql = "INSERT INTO VPN(ip, usuario, nombre, dependencia, direccion, gabinete, alta, baja) ";
                strSql += "VALUES(@ip, @usuario, @nombre, @dependencia, @direccion, @gabinete, @alta, @baja); ";
            }            
            else 
            {
                strSql = "INSERT INTO VPN(ip, usuario, nombre, dependencia, direccion, gabinete, alta) ";
                strSql += "VALUES(@ip, @usuario, @nombre, @dependencia, @direccion, @gabinete, @alta); ";
            }
            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);
           
            

            if(obj.Usuario == null)
            {
                obj.Usuario = "";
            }
            if(obj.Nombre == null)
            {
                obj.Nombre = "";
            }
            if(obj.Dependencia == null)
            {
                obj.Dependencia = "";
            }
            if(obj.Direccion == null)
            {
                obj.Direccion = "";
            }
            if(obj.Gabinete == null)
            {
                obj.Gabinete = "";
            }
            if(obj.Baja != null)
            {
                cmd.Parameters.AddWithValue("baja", obj.Baja);
            }
            else
            {
                cmd.Parameters.AddWithValue("baja", "");
            }

            cmd.Parameters.AddWithValue("ip", obj.Ip);
            cmd.Parameters.AddWithValue("usuario", obj.Usuario);
            cmd.Parameters.AddWithValue("nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("dependencia", obj.Dependencia);
            cmd.Parameters.AddWithValue("direccion", obj.Direccion);
            cmd.Parameters.AddWithValue("gabinete", obj.Gabinete);
            cmd.Parameters.AddWithValue("alta", obj.Alta);
            


            try 
            {

                conn.Open();
                
                //NpgsqlDataReader reader = cmd.ExecuteReader();
                if(cmd.ExecuteNonQuery() > 0)
                    ret = true;
                
                
            }
            catch(NpgsqlException ex)
            {
                
                throw;
            }
            finally
            {
                //if(conn.State != ConnectionState.Closed)
                    conn.Close();
                    conn.Dispose();
                
            }

            return ret;
        }
        //NI
        public bool Remove(int id)
        {

            throw new NotImplementedException();

        }
        //NI
        public bool Update(VPN obj)
        {
            throw new NotImplementedException();
        }
        //I
        public IEnumerable<VPN> FindAll()
        {
            List<VPN> TodasVPNs = new List<VPN>();

            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "SELECT * FROM vpn";
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
                System.Console.WriteLine("Postgre exception: " + ex);
                
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();

            }
            finally
            {
                
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();
                
            }

            return TodasVPNs;
        }
        //NI
        public VPN FindById(int id)
        {
            throw new NotImplementedException();
        }
       
        //I
        public IEnumerable<VPN> findVPN(List<string> IPs, string nombre, string alta, string baja, VPN.EnumTipo tipo)
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
                        
            if(alta != null && alta != "1/1/0001 00:00:00" && alta != "")
            {
                paramAlta = alta;
            }
            
            if(baja != null && baja != "1/1/0001 00:00:00" && baja != "")
            {
                paramBaja = baja;
            }

            
            
            if(tipo.GetHashCode()==1)
            {
                paramTipo = "192.168.";
            }
            else if(tipo.GetHashCode()==2)
            {
                paramTipo = "10.";
            }



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
                               if(tipo.GetHashCode()!=0)strSql += "AND (ip::text LIKE (@paramTipo)) ";
            if(nombre != null && nombre.Length > 0)
                strSql += "AND (nombre ILIKE (@paramNombre) OR usuario ILIKE (@paramNombre)) ";
            else
            {
                strSql += "AND ( (nombre ILIKE (@paramNombre)) OR (nombre IS NULL) OR usuario ILIKE (@paramNombre)) ";
            }

            strSql += "AND ((alta <= (@paramBaja)::timestamp OR alta IS NULL) AND " +
                                "(baja >= (@paramAlta)::timestamp OR baja IS NULL))";

            
            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);

            if(IPs != null && IPs.Count > 0)
                cmd.Parameters.Add("@paramLIp", NpgsqlDbType.Array|NpgsqlDbType.Inet).Value = IPAddrs;
            else
            {
                cmd.Parameters.AddWithValue("paramStringIp", "%"+paramStringIp+"%");
            }
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
                System.Console.WriteLine("Postgre exception: " + ex);

                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();

            }
            finally
            {
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();   
            }

            return TodasVPNs;


        }

        //I
        public bool isActive(IPAddress ip)
        {
            bool ret = false;
            
            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            
            string strSql = "SELECT * FROM vpn ";
                    strSql += "WHERE ip=@paramIp ";
                    strSql += "AND baja IS NULL;";
            
            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);

            
            cmd.Parameters.AddWithValue("paramIp", ip);
            
            try 
            {

                conn.Open();
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    ret = true;
                }
                
            }
            catch(NpgsqlException ex)
            {
                System.Console.WriteLine("Postgre exception: " + ex);
                
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();
            }
            finally
            {                
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();               
            }


            return ret;
        }

        //I
        // Se usa para editar 
        public VPN findByIds(IPAddress ip, DateTime? alta, DateTime? baja)
        {
            VPN nuevaVPN = new VPN();

            string conStr = "Host=10.1.1.64;Username=netflow;Password=lajirafaloca;Database=netflow";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
           
            string strSql = "SELECT * FROM vpn ";
                    strSql += "WHERE ip=@paramIp ";
                    if(alta != null && alta != DateTime.Parse("1/1/0001 00:00:00"))strSql += "AND alta=@paramalta ";
                    else strSql += "AND alta IS NULL ";
                    if(baja != null && baja != DateTime.Parse("1/1/0001 00:00:00"))strSql += "AND baja=@paramBaja;";
                    else strSql += "AND baja IS NULL;";
            
            NpgsqlCommand cmd = new NpgsqlCommand(strSql, conn);

            
            cmd.Parameters.AddWithValue("paramIp", ip);
            if(alta != null)cmd.Parameters.AddWithValue("paramAlta", alta);
            if(baja != null)cmd.Parameters.AddWithValue("paramBaja", baja);

            try 
            {

                conn.Open();
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
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

                }
                
            }
            catch(NpgsqlException ex)
            {
                System.Console.WriteLine("Postgre exception: " + ex);
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();
            }
            finally
            {
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                
                conn.Dispose();
            }



            return nuevaVPN;
        }

    }
}
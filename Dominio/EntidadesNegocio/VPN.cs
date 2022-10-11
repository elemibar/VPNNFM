using System;
using System.Collections.Generic;
using System.Net;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dominio.EntidadesNegocio
{
    
    public class VPN : IEquatable<VPN>, IValidable
    {
        [JsonConverter(typeof(IPAddressConverter))]
        public IPAddress Ip { get; set; }

        public string Usuario { get; set; } 

        public string Nombre { get; set; }

        public string Dependencia { get; set; }

        public string Direccion { get; set; }

        public string Gabinete { get; set; }
        
        
        public DateTime Alta { get; set; }

        public DateTime Baja { get; set; }

        public EnumTipo Tipo { get; set; }
        public List<Actividad> Actividades { get; set; }

        public VPN()
        {
            this.Actividades = new List<Actividad>();
        }


        public enum EnumTipo { Todos, Modem, Certificado }


        public bool Equals(VPN vpn)
        {
            bool ipIgual = false;
            bool altaIgual = false;
            bool bajaIgual = false;

            if(vpn == null) return false;

            if(vpn.Ip != null)
            {
                if(vpn.Ip.Equals(this.Ip))
                {
                    ipIgual = true;
                }
            }

            if(vpn.Alta == null && this.Alta == null)
            {
                altaIgual = true;
            }
            else if(vpn.Alta != null && this.Alta != null)
            {
                if(vpn.Alta.Equals(this.Alta))
                {
                    altaIgual = true;
                }
                else{ return false; }
            }
            else { return false; }
            


            if(vpn.Baja == null && this.Baja == null)
            {
                bajaIgual = true;
            }
            else if(vpn.Baja != null && this.Baja != null)
            {
                if(vpn.Baja.Equals(this.Baja))
                {
                    bajaIgual = true;
                }
                else{ return false; }
            }
            else { return false; }
            
            
            return ipIgual && altaIgual && bajaIgual; 

        }

        public bool Validate()
        {
            return true;
        }

        
    }  


    public class IPAddressConverter : JsonConverter<IPAddress>
    {
        /*
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IPAddress));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return IPAddress.Parse((string)reader.Value);
        }
        */

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IPAddress));
        }

        public override IPAddress Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
                IPAddress.Parse(reader.GetString());
        

        public override void Write(
            Utf8JsonWriter writer, 
            IPAddress ipValue, 
            JsonSerializerOptions options) => 
            writer.WriteStringValue(ipValue.ToString());

        
    }
    


}
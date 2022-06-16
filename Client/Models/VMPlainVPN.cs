using System;
using System.Collections.Generic;
using Dominio.EntidadesNegocio;

namespace Client.Models
{
    public class VMPlainVPN
    {

        public string Ip { get; set; }
        public string Alta { get; set; }

        public string Baja { get; set; }

        public VPN.EnumTipo Tipo { get; set; }

        
    }
}
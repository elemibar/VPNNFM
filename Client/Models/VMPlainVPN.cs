using System;
using System.Collections.Generic;
using Dominio.EntidadesNegocio;

namespace Client.Models
{
    public class VMPlainVPN
    {

        public string Ip { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Dependencia { get; set; }
        public string Direccion { get; set; }
        public string Gabinete { get; set; }
        public string Alta { get; set; }
        public string Baja { get; set; }
        public VPN.EnumTipo Tipo { get; set; }

        
    }
}
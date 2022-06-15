using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Microsoft.AspNetCore.Http;

namespace Client.Models
{
    public class ViewModelActividad
    {

        public IEnumerable<VPN> VPNs { get; set; }
        
        public VPN VPN;
        public List<string> Ips { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fin { get; set; }

        public VPN.EnumTipo Tipo { get; set; }

        public string Change { get; set; }
        
    }
}
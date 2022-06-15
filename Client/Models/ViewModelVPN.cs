using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Microsoft.AspNetCore.Http;

namespace Client.Models
{
    public class ViewModelVPN
    {

        public IEnumerable<VPN> VPNs { get; set; }
        public VPN VPN { get; set; }

        public List<string> IPs { get; set; }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;
using Microsoft.AspNetCore.Http;

namespace Client.Models
{
    public class VMActividad
    {

        public List<VPN> VPNs = new List<VPN>();

        public List<VMPlainVPN> PVPNs = new List<VMPlainVPN>();


        public VMActividad()
        {
            VPNs = new List<VPN>();
            PVPNs = new List<VMPlainVPN>();
        }
        
    }
}
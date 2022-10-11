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

        //Provisorio para enviar el modelo al controlador para un filtro, cuando se cambie a lista (con ajax y blabla) sacarlo
        public VMPlainVPN PVPN {get; set;}

        public List<string> IPs { get; set; }

        public ViewModelVPN()
        {
            VPNs = new List<VPN>();
            IPs = new List<string>();
        }
        
    }
}
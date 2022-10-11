using System.Collections.Generic;
using Dominio.EntidadesNegocio;


namespace Client.Models
{
    public class VMActividad
    {

        public List<VPN> VPNs = new List<VPN>(); //Para traer a la vista las VPNs con las actividades

        public List<VMPlainVPN> PVPNs = new List<VMPlainVPN>(); //Para mandar la lista de vpns a buscar al controller


        public VMActividad()
        {
            VPNs = new List<VPN>();
            PVPNs = new List<VMPlainVPN>();
        }
        
    }
}
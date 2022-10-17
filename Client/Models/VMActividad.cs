using System.Collections.Generic;
using Dominio.EntidadesNegocio;


namespace Client.Models
{
    public class VMActividad
    {

        public List<VPN> VPNs{get; set;} //Para traer a la vista las VPNs con las actividades

        public List<VMPlainVPN> PVPNs{get; set;} //Para mandar la lista de vpns a buscar al controller

        public int pagina{get;set;} // Pagina de actividades actual

        public int cantRows{get;set;} // Maxima cantidad de paginas (total de rows / tamanio de la pagina)

        public int tamanioPag{get;set;} // Tamanio de la pagina

        public VMActividad()
        {
            VPNs = new List<VPN>();
            PVPNs = new List<VMPlainVPN>();
        }
        
    }
}
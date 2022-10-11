using System;
using System.Collections.Generic;
using System.Net;
using Dominio.EntidadesNegocio;

namespace Dominio.IRepositorios
{


    public interface IRepositorioVPNs : IRepositorio<VPN>
    {

        IEnumerable<VPN> findVPN(List<string> IPs, string nombre, string alta, string baja, VPN.EnumTipo tipo);
        
         bool isActive(IPAddress ip);

         VPN findByIds(IPAddress ip, DateTime? alta, DateTime? baja);
    }


}
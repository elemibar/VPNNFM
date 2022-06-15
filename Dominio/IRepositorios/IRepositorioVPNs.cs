using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Dominio.EntidadesNegocio;

namespace Dominio.IRepositorios
{


    public interface IRepositorioVPNs : IRepositorio<VPN>
    {

        IEnumerable<VPN> findVPN(List<string> IPs, string nombre, DateTime? alta, DateTime? baja, VPN.EnumTipo tipo);
        
    }


}
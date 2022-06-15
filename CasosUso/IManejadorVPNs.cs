using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorVPNs
    {

        IEnumerable<VPN> TraerTodasVPN();
        IEnumerable<VPN> BuscarVPN(List<string> ip, string nombre, DateTime? alta, DateTime? Baja, VPN.EnumTipo tipo);

        
    }
}
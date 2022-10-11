using System;
using System.Collections.Generic;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorVPNs
    {

        IEnumerable<VPN> TraerTodasVPN();
        IEnumerable<VPN> BuscarVPN(List<string> ip, string nombre, string alta, string Baja, VPN.EnumTipo tipo);

        bool CrearVPN(VPN vpn);

        bool Activa(System.Net.IPAddress ip);

        VPN BuscarPorIdentificadores(System.Net.IPAddress ip, DateTime? alta, DateTime? baja);

    }
}
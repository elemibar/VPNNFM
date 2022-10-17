using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace CasosUso
{
    public interface IManejadorActividades
    {
        IEnumerable<VPN> BuscarActividad(List<string> ips, string incio, string fin, int pagina, int tamanioPag, VPN.EnumTipo tipo);

        Int64 CantidadActividades(List<string> IPs, string inicio, string fin, VPN.EnumTipo tipo);

        IEnumerable<VPN> TraerTodasActividades();
        
    }
}
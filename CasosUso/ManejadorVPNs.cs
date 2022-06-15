using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;

namespace CasosUso
{
    public class ManejadorVPNs : IManejadorVPNs
    {

        public IRepositorioVPNs RepoVPNs { get; set; }

        public ManejadorVPNs(IRepositorioVPNs repoVPNs)
        {

            RepoVPNs = repoVPNs;

        }

        public IEnumerable<VPN> TraerTodasVPN()
        {
            return RepoVPNs.FindAll();
        }

        public IEnumerable<VPN> BuscarVPN(List<string> ips, string nombre, DateTime? alta, DateTime? baja, VPN.EnumTipo tipo)
        {

            return RepoVPNs.findVPN(ips, nombre, alta, baja, tipo);

        }



    }
}
using System;
using System.Collections.Generic;
using System.Net;
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

        public IEnumerable<VPN> BuscarVPN(List<string> ips, string nombre, string alta, string baja, VPN.EnumTipo tipo)
        {
            return RepoVPNs.findVPN(ips, nombre, alta, baja, tipo);
        }

        public bool CrearVPN(VPN vpn)
        {
            return RepoVPNs.Add(vpn);
        }

        public bool Activa(System.Net.IPAddress ip)
        {
            return RepoVPNs.isActive(ip);
        }

        public VPN BuscarPorIdentificadores(System.Net.IPAddress ip, DateTime? alta, DateTime? baja)
        {
            return RepoVPNs.findByIds(ip, alta, baja);
        }

    }
}
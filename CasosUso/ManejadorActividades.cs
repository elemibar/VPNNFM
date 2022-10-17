using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.IRepositorios;

namespace CasosUso
{
    public class ManejadorActividades : IManejadorActividades
    {

        public IRepositorioActividades RepoActividades { get; set; }

        public ManejadorActividades(IRepositorioActividades repoActividades)
        {

            RepoActividades = repoActividades;

        }


        public IEnumerable<VPN> BuscarActividad(List<string> ips, string incio, string fin, int pagina, int tamanioPag, VPN.EnumTipo tipo)
        {
            return RepoActividades.findActividad(ips, incio, fin, pagina, tamanioPag, tipo);
        }

        public IEnumerable<VPN> TraerTodasActividades()
        {

            return RepoActividades.FindAllAVPN();

        }

        public Int64 CantidadActividades(List<string> IPs, string inicio, string fin, VPN.EnumTipo tipo)
        {
            return RepoActividades.findCantActividad(IPs, inicio, fin, tipo);
        }


    }
}
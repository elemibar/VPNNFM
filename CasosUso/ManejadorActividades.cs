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


        public IEnumerable<VPN> BuscarActividad(List<string> ips, string incio, string fin)
        {
            System.Console.WriteLine("ManAct BusAct");
            return RepoActividades.findActividad(ips, incio, fin);
        }

        public IEnumerable<VPN> TraerTodasActividades()
        {

            return RepoActividades.FindAllAVPN();

        }


    }
}
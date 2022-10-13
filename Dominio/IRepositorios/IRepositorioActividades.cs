using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.IRepositorios
{


    public interface IRepositorioActividades : IRepositorio<Actividad>
    {

        IEnumerable<VPN> findActividad(List<string> IP, string incio, string fin, int pagina, int tamanioPag);

        Int64 findCantActividad(List<string> IPs, string inicio, string fin);

        IEnumerable<VPN> FindAllAVPN();
        
    }


}
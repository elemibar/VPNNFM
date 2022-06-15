using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.IRepositorios
{


    public interface IRepositorioActividades : IRepositorio<Actividad>
    {

        IEnumerable<VPN> findActividad(List<string> IP, string incio, string fin);

        IEnumerable<VPN> FindAllAVPN();
        
    }


}
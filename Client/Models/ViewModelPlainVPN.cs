using System;
using System.Collections.Generic;
using Dominio.EntidadesNegocio;

namespace Client.Models
{
    public class ViewModelPlainVPN
    {

        public string IP { get; set; }
        public string Inicio { get; set; }

        public string Fin { get; set; }

        public VPN.EnumTipo Tipo { get; set; }

        
    }
}
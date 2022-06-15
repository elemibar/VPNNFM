using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{

    public class Usuario //: IValidate
    {
        string UserName { get; set; }
        string Password { get; set; } 

        public string Grupos { get; set; }

    }  


}
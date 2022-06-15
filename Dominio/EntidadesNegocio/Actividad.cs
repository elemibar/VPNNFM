using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Dominio.EntidadesNegocio
{

    public class Actividad //: IValidate
    {
        public IPAddress Ip { get; set; }

        public DateTime? Inicio { get; set; }

        public DateTime? Fin { get; set; }

        public int Segundos { get; set; }

        public IPAddress Destino { get; set; }

        public string Protocolo { get; set; }

        public int Puerto { get; set; }

        public string Bytesh { get; set; }

        public long Bytes { get; set; }

        public string Md5 { get; set; }
        

    }  


}
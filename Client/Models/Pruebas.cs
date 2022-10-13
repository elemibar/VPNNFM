using System.Collections.Generic;
using Dominio.EntidadesNegocio;


namespace Client.Models
{
    public class Pruebas
    {

        public int pagina{ get; set; } // Pagina de actividades actual

        public int cantRows{ get; set; } // Maxima cantidad de paginas (total de rows / tamanio de la pagina)

        public int tamanioPag{ get; set; } // Tamanio de la pagina
        
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Client.Models;
using Dominio.EntidadesNegocio;
using CasosUso;

namespace Client.Controllers
{

    public class VPNController : Controller
    {

       
        public IManejadorVPNs ManejadorVPNs{ get; set; }

        public VPNController(IManejadorVPNs manVPN)
        {
            ManejadorVPNs = manVPN;
        }

        public IActionResult Index()
        {
            
            ViewModelVPN vmvpn = new ViewModelVPN();
            vmvpn.VPNs = ManejadorVPNs.TraerTodasVPN();


            return View(vmvpn);
        }

        [HttpPost]
        public IActionResult Index(ViewModelVPN vmvpn)
        {
            //vmvpn.VPNs = ManejadorVPNs.BuscarVPN(vmvpn.IPs, vmvpn.VPN.Nombre, vmvpn.VPN.Alta, vmvpn.VPN.Baja, vmvpn.VPN.Tipo);
                        
            if (vmvpn.VPNs == null || vmvpn.VPNs.Count() == 0)
            {
                ViewBag.mensaje = "No hay VPNs que coincidan con la búsqueda.";
            }

            return View(vmvpn);
        }


    }


}
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
using System.Net;

namespace Client.Controllers
{

    public class ActividadController : Controller
    {

       
        public IManejadorActividades ManejadorActividades{ get; set; }

        public ActividadController(IManejadorActividades manActividades)
        {
            ManejadorActividades = manActividades;
        }
        
        public IActionResult Index()
        {
            
            IEnumerable<VPN> lvpn = new List<VPN>();
            lvpn = ManejadorActividades.BuscarActividad(null, "", "");

            return View(lvpn);
        }

        [HttpPost]
        public IActionResult Index([FromBody]List<ViewModelPlainVPN> vmpv)
        {
            
            List<String> lIpsStr = new List<string>();

            DateTime maxD = DateTime.Parse("01/01/0001");
            DateTime minD = DateTime.Parse("01/01/9999");
            String strIni = "";
            String strFin = "";

            foreach(ViewModelPlainVPN v in vmpv)
            {
                lIpsStr.Add(v.IP);

                if(v.Fin != "" && DateTime.Parse(v.Fin) > maxD)
                {
                    maxD=DateTime.Parse(v.Fin);
                    strFin = v.Fin;
                }

                if(v.Inicio != "" && DateTime.Parse(v.Inicio) < minD)
                {
                    minD=DateTime.Parse(v.Inicio);
                    strIni = v.Inicio;
                }

            }
                       
            
            
            List<VPN> lvpn = new List<VPN>();
            lvpn = ManejadorActividades.BuscarActividad(lIpsStr, strIni, strFin) as List<VPN>;
                        
            
            System.Console.WriteLine("Return de ActvControll");

            return View(lvpn);
        }


        [HttpPost]
        public ActionResult Test([FromBody]List<ViewModelPlainVPN> vma) //
        {   
            System.Console.WriteLine("Probando RenderSearch");
                       
            
            if(vma != null)
            {
                System.Console.WriteLine("VMA not null");
                if(vma.Count > 0)
                {
                    System.Console.WriteLine("VMA not empty");
                    foreach(ViewModelPlainVPN v in vma)
                    {
                        System.Console.WriteLine("ActControll RendSearch IP: " + v.IP.ToString());
                    }
                    
                    return Json(vma);
                }
                else{
                    System.Console.WriteLine("VMA not empty");
                }
            }else{
                System.Console.WriteLine("VMA NULL");
                vma = new List<ViewModelPlainVPN>();
                //vma.Add(new ViewModelPlainVPN(){IP="1.1.1.1", Inicio=DateTime.Parse("01/01/2000"), Fin=DateTime.Parse("10/06/2022")});
                //vma.Add(new ViewModelPlainVPN(){IP="2.2.2.2", Inicio=DateTime.Parse("25/10/2021"), Fin=DateTime.Parse("01/02/2022")});
                vma.Add(new ViewModelPlainVPN(){IP="1.1.1.1", Inicio="01/01/2000", Fin="10/06/2022"});
            }
            
            
            return Json(vma);

        }

    }


}
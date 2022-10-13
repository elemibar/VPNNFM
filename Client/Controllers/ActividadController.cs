using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Dominio.EntidadesNegocio;
using CasosUso;
using System.Net;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Client.Controllers
{

    public class ActividadController : Controller
    {

        static VMActividad acts = new VMActividad();
       
        public IManejadorActividades ManejadorActividades{ get; set; }

        public ActividadController(IManejadorActividades manActividades)
        {
            ManejadorActividades = manActividades;
        }

        
        public IActionResult Index(string ip, DateTime alta, DateTime baja, int pagina, int tamanioPag)
        {
            System.Console.WriteLine("ActControl/IndexG");

            if(HttpContext.Session.GetString("mail") != null)
            {
                VMActividad VMAct = new VMActividad();
                List<string> ips = new List<string>();

                if(ip != null && ip.Trim() != "" && ip.Trim().Length > 0)
                {
                    IPAddress direccionIP;
                    if(IPAddress.TryParse(ip, out direccionIP))
                    {
                        ips.Add(ip);
                    }
                    else
                    {
                        ViewBag.error = "Una de las direcciones IP ingresadas no es correcta. Verifique los campos.";
                    }
                }

                if(tamanioPag == 0) tamanioPag = 50;

                VMAct.tamanioPag = tamanioPag;
                VMAct.pagina = pagina;

                VMAct.cantRows = (int)ManejadorActividades.CantidadActividades(ips, alta.ToString(), baja.ToString());
                VMAct.VPNs = ManejadorActividades.BuscarActividad(ips, alta.ToString(), baja.ToString(), pagina, tamanioPag) as List<VPN>;

                return View(VMAct);
            }
            return RedirectToAction("Index", "Home");
        }

        /*
        [HttpPost]
        public IActionResult Index([FromBody]List<VMPlainVPN> vma, [FromBody]int pagina, [FromBody]int  tamanioPag)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("ActControl/IndexP");
            System.Console.WriteLine("Datos de que llegan a consulta: Lista: " + vma + "pag: " + pagina + "tamanio: " + tamanioPag);

            if(HttpContext.Session.GetString("mail") != null)
            {
                List<String> lIpsStr = new List<string>();

                DateTime maxD = DateTime.Parse("01/01/0001");
                DateTime minD = DateTime.Parse("01/01/9999");
                String strIni = "";
                String strFin = "";

                if(vma != null)
                {

                    foreach(VMPlainVPN v in vma)
                    {
                        if(v.Ip != null && v.Ip.Trim() != "" && v.Ip.Trim().Length > 0)
                        {
                            IPAddress direccionIP;
                            if(IPAddress.TryParse(v.Ip, out direccionIP))
                            {
                                lIpsStr.Add(v.Ip);
                            }
                            else
                            {
                                ViewBag.error = "Una de las direcciones IP ingresadas no es correcta. Verifique los campos.";
                            }
                        }
                        if(v.Baja != "" && DateTime.Parse(v.Baja) > maxD)
                        {
                            maxD=DateTime.Parse(v.Baja);
                            strFin = v.Baja;
                        }

                        if(v.Alta != "" && DateTime.Parse(v.Alta) < minD)
                        {
                            minD=DateTime.Parse(v.Alta);
                            strIni = v.Alta;
                        }

                    }
                            
                }
                
                VMActividad VMAct = new VMActividad();

                List<VPN> lvpn = new List<VPN>();
                
                VMAct.cantRows = (int)ManejadorActividades.CantidadActividades(lIpsStr, strIni, strFin);
                System.Console.WriteLine("Cantidad total de Rows: " + VMAct.cantRows);
                
                if(tamanioPag==0) tamanioPag=50;
                
                VMAct.tamanioPag = tamanioPag;

                lvpn = ManejadorActividades.BuscarActividad(lIpsStr, strIni, strFin, pagina, tamanioPag) as List<VPN>;

                if(lvpn.Count <= 0)
                {
                    ViewBag.mensaje = "No se encontraron actividades con esos criterios.";
                }
                
                VMAct.VPNs=lvpn;

                return View(VMAct);
            }
            return RedirectToAction("Index", "Home");
        }*/

        /*[HttpGet]
        public IActionResult Index([FromBody]VMActividad vma)
        {*/
        [HttpPost]
        public IActionResult Index([FromBody]VMActividad vma)
        {
            
            if(HttpContext.Session.GetString("mail") != null)
            {
                List<String> lIpsStr = new List<string>();
                List<VPN> lvpn = new List<VPN>();
                
                VMActividad VMAct = new VMActividad();

                DateTime maxD = DateTime.Parse("01/01/0001");
                DateTime minD = DateTime.Parse("01/01/9999");
                String strIni = "";
                String strFin = "";

                int pagina = 0;
                int tamanioPag = 50;

                if(vma != null)
                {
                    System.Console.WriteLine("Datos de que llegan a consulta: Obj: " + JsonSerializer.Serialize(vma).ToString() + " Lista: " + vma.PVPNs.Count + " pag: " + vma.pagina + " tamanio: " + vma.tamanioPag);

                    foreach(VMPlainVPN v in vma.PVPNs)
                    {
                        if(v.Ip != null && v.Ip.Trim() != "" && v.Ip.Trim().Length > 0)
                        {
                            IPAddress direccionIP;
                            if(IPAddress.TryParse(v.Ip, out direccionIP))
                            {
                                lIpsStr.Add(v.Ip);
                            }
                            else
                            {
                                ViewBag.error = "Una de las direcciones IP ingresadas no es correcta. Verifique los campos.";
                            }
                        }
                        if(v.Baja != "" && DateTime.Parse(v.Baja) > maxD)
                        {
                            maxD=DateTime.Parse(v.Baja);
                            strFin = v.Baja;
                        }

                        if(v.Alta != "" && DateTime.Parse(v.Alta) < minD)
                        {
                            minD=DateTime.Parse(v.Alta);
                            strIni = v.Alta;
                        }

                    }

                    pagina = vma.pagina;
                    tamanioPag = vma.tamanioPag;
                }
                else
                {
                    pagina = 0;
                    tamanioPag = 50;
                }
                
                
                VMAct.cantRows = (int)ManejadorActividades.CantidadActividades(lIpsStr, strIni, strFin);
                System.Console.WriteLine("Cantidad total de Rows: " + VMAct.cantRows);
                
                if(tamanioPag==0) tamanioPag=50;
                
                VMAct.tamanioPag = tamanioPag;

                lvpn = ManejadorActividades.BuscarActividad(lIpsStr, strIni, strFin, pagina, tamanioPag) as List<VPN>;

                if(lvpn.Count <= 0)
                {
                    ViewBag.mensaje = "No se encontraron actividades con esos criterios.";
                }
                
                VMAct.VPNs=lvpn;

                return View(VMAct);
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public ActionResult AddVPN([FromBody]List<VMPlainVPN> vma) //
        {   
            if(HttpContext.Session.GetString("mail") != null)
            {
                if(vma != null)
                {
                    
                    if(vma.Count > 0)
                    {
                        
                        acts.PVPNs = vma;
                        return PartialView("_tableActs", acts);
                    }
                    
                }

                acts.PVPNs = vma;
                
                return PartialView("_tableActs", acts);
            }
            return RedirectToAction("Index", "Home");

        }


    }

}
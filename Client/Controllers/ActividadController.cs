using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Dominio.EntidadesNegocio;
using CasosUso;
using System.Net;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

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

                VMAct.cantRows = (int)ManejadorActividades.CantidadActividades(ips, alta.ToString(), baja.ToString(), VPN.EnumTipo.Todos);
                

                VMAct.VPNs = ManejadorActividades.BuscarActividad(ips, alta.ToString(), baja.ToString(), pagina, tamanioPag, VPN.EnumTipo.Todos) as List<VPN>;

                VMAct.PVPNs.Add(new VMPlainVPN{Ip=ip, Alta=alta.ToString(), Baja=baja.ToString()});

                return View(VMAct);
                
            }
            return RedirectToAction("Index", "Home");
        }

        
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
                VPN.EnumTipo tipoLogico = VPN.EnumTipo.Todos;


                if(vma != null)
                {
                    

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

                        if(v.Tipo.GetHashCode() != 0)
                        {
                            if(tipoLogico.GetHashCode() != 0)
                            {
                                if(tipoLogico != v.Tipo)
                                {
                                    tipoLogico = VPN.EnumTipo.Todos;
                                }
                                else
                                {
                                    tipoLogico = v.Tipo;
                                }
                            }
                            else
                            {
                                tipoLogico = v.Tipo;
                            }
                        }


                    }

                    VMAct.pagina = vma.pagina;
                    VMAct.tamanioPag = vma.tamanioPag;

                    VMAct.PVPNs = vma.PVPNs;

                    if(vma.tamanioPag==0) VMAct.tamanioPag=50;
                }
                else
                {
                    
                    VMAct.pagina = 0;
                    VMAct.tamanioPag = 50;
                }
                
                VMAct.cantRows = (int)ManejadorActividades.CantidadActividades(lIpsStr, strIni, strFin, tipoLogico);
                      
                lvpn = ManejadorActividades.BuscarActividad(lIpsStr, strIni, strFin, VMAct.pagina, VMAct.tamanioPag, tipoLogico) as List<VPN>;

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
        public ActionResult AddVPN([FromBody]VMActividad vma)
        {   
            if(HttpContext.Session.GetString("mail") != null)
            {
                if(vma != null)
                {
                    
                    if(vma.PVPNs.Count > 0)
                    {
                        
                        acts = vma;
                        return PartialView("_tableActs", acts);
                    }
                    
                }

                acts = vma;
                
                return PartialView("_tableActs", acts);
            }
            return RedirectToAction("Index", "Home");

        }

        [HttpPost]
        public ActionResult DownloadCSV([FromBody]VMActividad vma)
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
                VPN.EnumTipo tipoLogico = VPN.EnumTipo.Todos;


                if(vma != null)
                {
                    

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

                        if(v.Tipo.GetHashCode() != 0)
                        {
                            if(tipoLogico.GetHashCode() != 0)
                            {
                                if(tipoLogico != v.Tipo)
                                {
                                    tipoLogico = VPN.EnumTipo.Todos;
                                }
                                else
                                {
                                    tipoLogico = v.Tipo;
                                }
                            }
                            else
                            {
                                tipoLogico = v.Tipo;
                            }
                        }


                    }

                    VMAct.pagina = vma.pagina;
                    VMAct.tamanioPag = vma.tamanioPag;

                    VMAct.PVPNs = vma.PVPNs;

                }
                
                
                
                VMAct.cantRows = (int)ManejadorActividades.CantidadActividades(lIpsStr, strIni, strFin, tipoLogico);
                          

                lvpn = ManejadorActividades.BuscarActividad(lIpsStr, strIni, strFin, 0, VMAct.cantRows, tipoLogico) as List<VPN>;
                
                VMAct.VPNs=lvpn;
                
                return Ok(Json(lvpn));
            }

            return RedirectToAction("Index", "Home");
            

        }


    }

}
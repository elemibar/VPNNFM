using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using CasosUso;
using System.Net;
using Dominio.EntidadesNegocio;
using System;
using Microsoft.AspNetCore.Http;

namespace Client.Controllers
{

    public class VPNController : Controller
    {


        public IManejadorVPNs ManejadorVPNs { get; set; }

        public VPNController(IManejadorVPNs manVPN)
        {
            ManejadorVPNs = manVPN;
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("mail") != null)
            {
                
                ViewModelVPN vmvpn = new ViewModelVPN();
                vmvpn.VPNs = ManejadorVPNs.TraerTodasVPN();


                return View(vmvpn);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Index(ViewModelVPN vmvpn)
        {
            if(HttpContext.Session.GetString("mail") != null)
            {
                List<string> IpsList = new List<string>();

                if (vmvpn != null && vmvpn.PVPN != null && vmvpn.PVPN.Ip != null)
                {

                    IPAddress direccionIP;

                    if (IPAddress.TryParse(vmvpn.PVPN.Ip, out direccionIP))
                    {
                        IpsList.Add(vmvpn.PVPN.Ip.ToString());
                    }
                    else
                    {
                        ViewBag.error = "Una de las direcciones IP ingresadas no es correcta. Verifique los campos.";
                    }

                }

                vmvpn.VPNs = ManejadorVPNs.BuscarVPN(IpsList, vmvpn.VPN.Nombre, vmvpn.VPN.Alta.ToString(), vmvpn.VPN.Baja.ToString(), vmvpn.VPN.Tipo);

                if (vmvpn.VPNs == null || vmvpn.VPNs.Count() == 0)
                {
                    ViewBag.mensaje = "No hay VPNs que coincidan con la búsqueda.";
                }

                return View(vmvpn);
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Create()
        {
            if(HttpContext.Session.GetString("mail") != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Create(VMPlainVPN vmpvpn)
        {
            if(HttpContext.Session.GetString("mail") != null)
            {

                bool valido = true;

                VPN vpn = new VPN();

                if (vmpvpn.Ip != null && vmpvpn.Ip.Trim() != "" && vmpvpn.Ip.Trim().Length > 0)
                {
                    IPAddress ip;
                    if (IPAddress.TryParse(vmpvpn.Ip, out ip))
                    {
                        vpn.Ip = ip;

                        if (vmpvpn.Alta != null && vmpvpn.Alta.Trim() != "")
                        {
                            DateTime dta;
                            if (DateTime.TryParse(vmpvpn.Alta, out dta))
                            {
                                vpn.Alta = dta;
                            }
                            else
                            {
                                valido = false;
                                ViewBag.error = "La fecha de alta no es válida";
                            }
                        }

                        if (vmpvpn.Baja != null && vmpvpn.Baja.Trim() != "")
                        {
                            DateTime dtb;
                            if (DateTime.TryParse(vmpvpn.Baja, out dtb))
                            {
                                vpn.Baja = dtb;
                            }
                            else
                            {
                                valido = false;
                                ViewBag.error = "La fecha de baja no es válida";
                            }
                        }
                        if(valido)
                        {
                            if(!ManejadorVPNs.Activa(vpn.Ip))
                            {

                                vpn.Usuario = vmpvpn.Usuario;
                                vpn.Nombre = vmpvpn.Nombre;
                                vpn.Dependencia = vmpvpn.Dependencia;
                                vpn.Direccion = vmpvpn.Direccion;
                                vpn.Gabinete = vmpvpn.Gabinete;

                                if (ManejadorVPNs.CrearVPN(vpn))
                                {
                                    ViewBag.creado = "La VPN se creó correctamente.";
                                }
                                else
                                {
                                    ViewBag.error = "La VPN no se pudo crear correctamente.";
                                }
                            }
                            else
                            {
                                ViewBag.error = "La VPN que está intentando dar de alta se encuentra en uso, ingrese la fecha de baja para la VPN correspondiente.";
                            }

                        }
                    }
                    else
                    {
                        ViewBag.error = "La dirección IP no es válida.";
                    }
                }
                else
                {
                    ViewBag.error = "La dirección IP no es válida.";
                }

                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(string ip, string alta, string baja)
        {
            if(HttpContext.Session.GetString("mail") != null)
            {
            DateTime? palta = null;
            DateTime? pbaja = null;

            System.Console.WriteLine("VPNControl Edit - alta param: " + alta);
            System.Console.WriteLine("VPNControl Edit - baja param: " + baja);

            if(alta != null && alta.Length > 0 && alta != "01/01/0001 00:00:00")
            {
                palta = DateTime.Parse(alta, new System.Globalization.CultureInfo("en-US", false));
                System.Console.WriteLine("VPNControl Edit - parsed alta: " + palta);
            
            }
            
            if(baja != null && baja.Length > 0 && baja != "01/01/0001 00:00:00")
            {
                pbaja = DateTime.Parse(baja, new System.Globalization.CultureInfo("en-US", false));
                System.Console.WriteLine("VPNControl Edit - parsed baja: " + pbaja);
            }
            
            VPN vpn = ManejadorVPNs.BuscarPorIdentificadores(IPAddress.Parse(ip), palta, pbaja);
            if(vpn != null)
            {
             
                VMPlainVPN vmpvpn = new VMPlainVPN();

                if(vpn.Ip != null) vmpvpn.Ip = vpn.Ip.ToString();
                if(vpn.Usuario != null) vmpvpn.Usuario = vpn.Usuario;
                if(vpn.Nombre != null) vmpvpn.Nombre = vpn.Nombre;
                if(vpn.Dependencia != null) vmpvpn.Dependencia = vpn.Dependencia;
                if(vpn.Direccion != null) vmpvpn.Direccion = vpn.Direccion;
                if(vpn.Gabinete != null) vmpvpn.Gabinete = vpn.Gabinete;
                if(vpn.Alta != null) vmpvpn.Alta = vpn.Alta.Date.ToString("yyyy-MM-dd");
                if(vpn.Baja != null) vmpvpn.Baja = vpn.Baja.Date.ToString("yyyy-MM-dd");
                vmpvpn.Tipo = vpn.Tipo;
                
                System.Console.WriteLine("ALTA vpn obj: " + vmpvpn.Alta);
                System.Console.WriteLine("BAJA vpn obj: " + vmpvpn.Baja);
                                
                return View(vmpvpn);
            }
 
            return View();
            }
            return RedirectToAction("Home", "Index");
        }

        [HttpPost]
        public ActionResult Edit(VMPlainVPN vmpvpn)
        {
            if(HttpContext.Session.GetString("mail") != null)
            {
                return View();
            }
            return RedirectToAction("Home", "Index");
        }

        public ActionResult Delete(string ip, string alta, string baja)
        {
            if(HttpContext.Session.GetString("mail") != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

    }


}
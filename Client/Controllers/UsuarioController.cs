using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasosUso;
using Microsoft.AspNetCore.Http;

namespace Client.Controllers
{
    public class UsuarioController : Controller
    {

        private IManejadorUsuarios manejadorUsuarios{ get; set; }
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, IManejadorUsuarios manUsu)
        {
            _logger = logger;
            manejadorUsuarios = manUsu;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("mail") == null)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            if(HttpContext.Session.GetString("mail") == null)
            {

                if(manejadorUsuarios.Login(username, password))
                {

                    HttpContext.Session.SetString("mail", username);

                    return RedirectToAction("Index", "Home");
                
                }
                else
                {
                    ViewBag.msg = "No se pudo iniciar sesión, verifique sus credenciales.";
                    return View();
                }
            }

            return View();

        }

        public IActionResult Logout()
        {

            if(HttpContext.Session.GetString("mail") != null)
            {
                HttpContext.Session.Clear();
            }

            return RedirectToAction("Index", "Home");
        }
       
    }
}

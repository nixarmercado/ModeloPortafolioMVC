using Microsoft.AspNetCore.Mvc;
using PortafolioDevsNixar.Models;
using PortafolioDevsNixar.Servicios;
using System.Diagnostics;

namespace PortafolioDevsNixar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos _repositorioProyectos;

        public HomeController(IRepositorioProyectos repositorioProyectos)
        {
            _repositorioProyectos = repositorioProyectos;
        }
        public IActionResult Index() //Son acciones, dan respuestas http a las solicitudes
        {//repositorioProyectos como un campo
            var proyectos = _repositorioProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };

            return View(modelo);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//using PortafolioDevsNixar.Models;

namespace PortafolioDevsNixar.Models
{
    /*Clase para encapsular toda información que sea necesaria para cargar
      la vista Index,y en este caso para la lista de proyectos a cargar aca
     */
    public class HomeIndexViewModel
    {
        public IEnumerable<ProyectoDTO> Proyectos { get; set; }
    }
}

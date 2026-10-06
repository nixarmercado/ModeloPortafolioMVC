using PortafolioDevsNixar.Models;

namespace PortafolioDevsNixar.Servicios
{
    //
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    /*Un repositorio es basicamente una clase que se encarga en recibir datos
     lo que hace es que se conecta a una base de datos, para conseguir los datos
    o realizar cualquier operación en la base de datos.
    */

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {
                new ProyectoDTO
            {
                Titulo ="Amazon",
                Descripcion ="E-commerce realizado en ASP.NET Core",
                Link ="https://amazon.com",
                ImagenURL="/imagenes/amazon.PNG"
            },

                new ProyectoDTO
            {
                Titulo ="New York Times",
                Descripcion ="Páginas de noticias en React",
                Link ="https://nytimes.com",
                ImagenURL="/imagenes/nyt.PNG"
            },

                new ProyectoDTO
            {
                Titulo ="Reddit",
                Descripcion ="Red social para compartir en comunidades",
                Link ="https://redit.com",
                ImagenURL="/imagenes/reddit.PNG"
            },

                new ProyectoDTO
            {
                Titulo ="Steam",
                Descripcion ="Tienda en linea para comprar video juegos",
                Link ="https://store/steampowered.com",
                ImagenURL="/imagenes/steam.PNG"
            },
            };
        }
    }
}

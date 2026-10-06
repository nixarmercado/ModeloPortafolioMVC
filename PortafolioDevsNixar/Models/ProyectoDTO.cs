namespace PortafolioDevsNixar.Models
{
    /*contendra la data del proytecto en ocasiones se le ponde como nombre
     ViewModel, o DTO (data transfer object) -->Objeto de Transferecia de Datos  por que su funcionalidad
    es una manera identificar las clase que solo  van a llevar datos de un lugar 
    a otro    
     */
    public class ProyectoDTO
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }
        public string Link { get; set; }
    }
}

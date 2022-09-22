using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{
    public class DirectorTecnico
    {
        
        public int Id { get; set; }
        [Display(Name = "Nombre del Director Tecnico")]
        public string Nombre { get; set; }
        [Display(Name = "Documento del DT")]
        public int Documento { get; set; }
        [Display(Name = "Telefono del DT")]
        public int Telefono  { set; get; }
        public List<Equipo> Equipos {get; set;}


    }
}   
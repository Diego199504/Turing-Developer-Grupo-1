using System;
using System.ComponentModel.DataAnnotations;


namespace Torneo.App.Dominio
{
    
    public class Equipo
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del Equipo")]
        public string Nombre { get; set; }
        [Display(Name = "Seleccione Municipio del Equipo")]
        public Municipio Municipio { get; set; }
        [Display(Name = "Seleccione Tecnico del Equipo")]
        public DirectorTecnico DirectorTecnico { get; set; }
        
    }
}
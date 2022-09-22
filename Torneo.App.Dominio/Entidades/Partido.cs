using System;
using System.ComponentModel.DataAnnotations;


namespace Torneo.App.Dominio
{
    
    public class Partido
    {
        public int Id { get; set; }

        [Display(Name = "Programe la Hora del Partido")]
        public DateTime FechaHora { get; set; }
        //public Equipo Equipo {get; set; }
        [Required(ErrorMessage = "Seleccionar un Equipo Visitante es Obligatorio")]
        public Equipo Visitante {get; set; }
        [Required(ErrorMessage = "Seleccionar un Equipo Local es Obligatorio")]
        public Equipo Local {get; set; }
        public int MarcadorEquipoLocal {get; set; }
        public int MarcadorEquipoVisitante {get; set; }
    }
}
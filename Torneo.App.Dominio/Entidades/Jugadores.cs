using System;
using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{

    public class Jugadores
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del Jugador")]
        public string Nombre { get; set; }
        [Display(Name = "Numero del Jugador")]
        public int Numero { get; set; }
        [Display(Name = "Seleccione Posicion del Jugador")]
        public Posicion Posicion {get; set;}
        [Display(Name = "Seleccione Equipo del Jugador")]
        public Equipo Equipo { get; set; }
    }
}

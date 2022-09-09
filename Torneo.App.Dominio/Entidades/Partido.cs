using System;


namespace Torneo.App.Dominio
{
    
    public class Partido
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        //public Equipo Equipo {get; set; }
        public Equipo Visitante {get; set; }
        public Equipo Local {get; set; }
        public int MarcadorEquipoLocal {get; set; }
        public int MarcadorEquipoVisitante {get; set; }
    }
}
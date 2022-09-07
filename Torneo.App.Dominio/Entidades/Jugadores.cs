using System;


namespace Torneo.App.Dominio
{

    public class Jugadores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public Posicion Posicion {get; set;}
        public Equipo Equipo { get; set; }
    }
}

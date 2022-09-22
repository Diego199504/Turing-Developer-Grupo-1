using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugador 
    {
        public Jugadores AddJugador (Jugadores jugador,  int idPosicion, int idEquipo);
        public IEnumerable<Jugadores> GetAllJugadores();
        public Jugadores GetJugador(int idJugador);
        public Jugadores UpdateJugador(Jugadores jugador, int idEquipo, int idPosicion);
        public Jugadores DeleteJugador(int idJugador);
    }
}   

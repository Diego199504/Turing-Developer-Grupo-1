using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugador 
    {
        public Jugadores AddJugador (Jugadores jugador,  int idPosicion, int idEquipo);
        public IEnumerable<Jugadores> GetAllJugadores();
    }
}   

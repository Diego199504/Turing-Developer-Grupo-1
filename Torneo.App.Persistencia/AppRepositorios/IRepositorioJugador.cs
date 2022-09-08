using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugador {
        public Jugador AddJugador (Jugador jugador);
    }
}   
using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly DataContext _dataContext = new DataContext();
        public Jugadores AddJugador(Jugadores jugador, int idPosicion, int idEquipo)
        {

            var posicionEncontrado = _dataContext.Posicion.Find(idPosicion);
            var equipoEncontrado = _dataContext.Equipos.Find(idEquipo);
            jugador.Posicion = posicionEncontrado;
            jugador.Equipo = equipoEncontrado;
            var jugadorInsertado = _dataContext.Jugadores.Add(jugador);
            _dataContext.SaveChanges();
            return jugadorInsertado.Entity;
        }

        public IEnumerable<Jugadores> GetAllJugadores()
        {
            var jugadores = _dataContext.Jugadores
               .Include(e => e.Posicion)
               .Include(e => e.Equipo)
               .ToList();
            return jugadores;
        }

        public Jugadores GetJugador(int idJugador)
        {
            var jugadorEncontrado = _dataContext.Jugadores
                .Where(e => e.Id == idJugador)
                .Include(e => e.Posicion)
                .Include(e => e.Equipo)
                .FirstOrDefault();

            //.ToList();

            return jugadorEncontrado;

        }
        public Jugadores UpdateJugador(Jugadores jugador, int idEquipo, int idPosicion)
        {
            var jugadorEncontrado = GetJugador(jugador.Id);
            var equipoEncontrado = _dataContext.Equipos.Find(idEquipo);
            var posicionEncontrada = _dataContext.Posicion.Find(idPosicion);
            jugadorEncontrado.Nombre = jugador.Nombre;
            jugadorEncontrado.Numero = jugador.Numero;
            jugadorEncontrado.Equipo = equipoEncontrado;
            jugadorEncontrado.Posicion = posicionEncontrada;

            _dataContext.SaveChanges();
            return jugadorEncontrado;
        }

        public Jugadores DeleteJugador(int idJugador){
            var jugadorEcontrado = _dataContext.Jugadores.Find(idJugador);
            if(jugadorEcontrado != null)
            {
                _dataContext.Jugadores.Remove(jugadorEcontrado);
                _dataContext.SaveChanges();
            }
            return jugadorEcontrado;
        }

    }
}

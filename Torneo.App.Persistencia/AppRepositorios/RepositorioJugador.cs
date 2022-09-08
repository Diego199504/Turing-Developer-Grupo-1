using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
 public class RepositorioJugador : IRepositorioJugador
 {
    private readonly DataContext_ dataContext_= new DataContext(); 
     public Jugador AddJugador(Jugador jugador, int idJugador, int idDT)
        {
            
            var JugadorInsertado = _dataContext.Jugador.Add(jugador);
            _dataContext.SaveChanges();
            return JugadorInsertado.Entity;
        }
        
 }
}

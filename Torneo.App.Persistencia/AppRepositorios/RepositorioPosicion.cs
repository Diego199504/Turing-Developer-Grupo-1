using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioPosicion : IRepositorioPosicion
    {
        private readonly DataContext _dataContext = new DataContext();
        public Posicion AddPosicion(Posicion posicion)
        {
            var posicionInsertada = _dataContext.Posicion.Add(posicion);
            _dataContext.SaveChanges();
            return posicionInsertada.Entity;
        }
        public IEnumerable<Posicion> GetAllPosiciones()
        {
            return _dataContext.Posicion;
        }
        public Posicion GetPosicion(int idPosicion)

        {
            var posicionEncontrada = _dataContext.Posicion.Find(idPosicion);
            return posicionEncontrada;
        }
        public Posicion UpdatePosicion(Posicion posicion)
        {
            var posicionEncontrada = _dataContext.Posicion.Find(posicion.Id);
            if (posicionEncontrada != null)
            {
                posicionEncontrada.Nombre = posicion.Nombre;
                _dataContext.SaveChanges();
            }
            return posicionEncontrada;
        }
    }
}
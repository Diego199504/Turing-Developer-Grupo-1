using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext();
        public Partido AddPartido(Partido partido, int idEquiposLocal, int idEquiposVisitante)
        {
            var equipoEncontradoLocal = _dataContext.Equipos.Find(idEquiposLocal);
            var equipoEncontradoVisitante = _dataContext.Equipos.Find(idEquiposVisitante);
            partido.Local = equipoEncontradoLocal;
            partido.Visitante = equipoEncontradoVisitante;
            //partido.Visitante = equipoEncontradoVisitante;
            var partidoInsertado = _dataContext.Partidos.Add(partido);
            _dataContext.SaveChanges();
            return partidoInsertado.Entity;
        }
        public Municipio GetPartido(int idPartido)
        {
           var partidos = _dataContext.Partidos
                .Include(p => p.Local)
                .Include(p => p.Visitante)
               // .Include(p => p.Equipo.idEquiposVisitante)
                .ToList();

            return partidos;
        }
    }
}
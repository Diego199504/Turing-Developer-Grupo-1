using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartido
    {
        public Partido AddPartido(Partido partido, int idEquiposLocal, int idEquiposVisitante);
        public IEnumerable<Partido> GetAllPartidos();
    }
}

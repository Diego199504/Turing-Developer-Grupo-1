using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly DataContext _dataContext = new DataContext();

        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var dtInsertado = _dataContext.Tecnicos.Add(directorTecnico);
            _dataContext.SaveChanges();
            return dtInsertado.Entity;
        }
        public IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos()
        {
            return _dataContext.Tecnicos;
        }
        public DirectorTecnico GetDirectorTecnico(int idDirectorTecnico)

        {
            var directorTecnicoEncontrado = _dataContext.Tecnicos.Find(idDirectorTecnico);
            return directorTecnicoEncontrado;
        }
    }
}
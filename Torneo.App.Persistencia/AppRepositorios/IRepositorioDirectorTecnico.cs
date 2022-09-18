using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
       public IEnumerable<DirectorTecnico> GetAllDirectoresTecnicos();
       public DirectorTecnico GetDirectorTecnico(int idDirectorTecnico);
       public DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico);
    }
}
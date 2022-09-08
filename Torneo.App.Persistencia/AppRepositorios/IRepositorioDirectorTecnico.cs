using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
       
    }
}
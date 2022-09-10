using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Dts
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public IEnumerable<DirectorTecnico> directorTecnico { get; set;}
        public IndexModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
             _repoDirectorTecnico = repoDirectorTecnico;
        }    
        public void OnGet()
        {
            directorTecnico = _repoDirectorTecnico.GetAllDirectoresTecnicos();
        
        }
    }
}   

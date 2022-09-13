using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Partido;

    public class IndexModel : PageModel
{
        private readonly IRepositorioPartido _repoPartido;
        public IEnumerable<Partido> Partido {get;set;}
        public IndexModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }

        public void OnGet()
        {
            Partido = _repoPartido.GetAllPartidos();
            
        }
}

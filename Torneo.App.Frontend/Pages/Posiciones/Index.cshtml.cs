
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Posiciones
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPosicion _repoPosicion;
        public IEnumerable<Posicion> posiciones { get;set;}
        public IndexModel(IRepositorioPosicion _repoPosicion)
        {
            _repoPosicion = _repoPosicion;
        }
        public void OnGet()
        {
            posiciones = _repoPosicion.GetAllPosiciones();

        }
    }
}

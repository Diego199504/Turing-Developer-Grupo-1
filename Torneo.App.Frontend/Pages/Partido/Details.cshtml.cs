using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Partido
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Dominio.Partido partido { get; set; }
        public DetailsModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }

        public IActionResult OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);

            if (partido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }

        }
    }
}

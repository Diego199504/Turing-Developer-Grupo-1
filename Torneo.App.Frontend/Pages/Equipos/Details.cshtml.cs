using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Equipos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public Equipo Equipo { get; set;}
        public DetailsModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;

        }
         public IActionResult OnGet(int id)
        { 
            Equipo = _repoEquipo.GetEquipo(id);
            if (Equipo == null)
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

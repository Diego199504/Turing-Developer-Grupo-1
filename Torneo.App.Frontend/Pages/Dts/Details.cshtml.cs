using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Dts
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico DirectorTecnico { get; set;}
        public DetailsModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }

        public IActionResult OnGet(int id)
        { 
            DirectorTecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            if (DirectorTecnico == null)
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

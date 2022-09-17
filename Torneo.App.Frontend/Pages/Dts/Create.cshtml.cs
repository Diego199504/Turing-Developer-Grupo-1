using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Dts
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDTecnico;
        public DirectorTecnico directorTecnico { get; set; }
        public CreateModel(IRepositorioDirectorTecnico repoDTecnico)
        {
            _repoDTecnico = repoDTecnico;
        }
        public void OnGet()
        {
            directorTecnico = new DirectorTecnico();
        }
        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            if (ModelState.IsValid)
            {
                _repoDTecnico.AddDirectorTecnico(directorTecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}

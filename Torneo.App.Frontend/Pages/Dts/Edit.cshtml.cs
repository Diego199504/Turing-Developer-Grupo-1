using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Dts
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDTs;
        public DirectorTecnico DTs { get; set; }
        public EditModel(IRepositorioDirectorTecnico repoDTs)
        {
            _repoDTs = repoDTs;
        }
        public IActionResult OnGet(int id)
        {
            DTs = _repoDTs.GetDirectorTecnico(id);
            if (DTs == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(DirectorTecnico DTs)
        {
            _repoDTs.UpdateDirectorTecnico(DTs);
            return RedirectToPage("Index");
        }
    }
}

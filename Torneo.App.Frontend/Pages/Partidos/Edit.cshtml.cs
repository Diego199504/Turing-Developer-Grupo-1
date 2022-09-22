using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering; // Libreria para trabajar con selects 
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Partidos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipoLocal;
        private readonly IRepositorioEquipo _repoEquipoVisitante;

        public Partido partido { get; set; }
        public SelectList equipoLOption{get; set;}
        public SelectList equipoVOption{get; set;}

        public int equipoLSelected { get; set; }
        public int equipoVSelected { get; set; }

        //Instanciar las propiedades
         public EditModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipoLocal,IRepositorioEquipo repoEquipoVisitante)
        {
            _repoPartido = repoPartido;
            _repoEquipoLocal = repoEquipoLocal;
            _repoEquipoVisitante = repoEquipoVisitante;
        }

        public IActionResult OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);
            equipoLOption = new SelectList(_repoEquipoLocal.GetAllEquipos(), "Id", "Nombre");
            equipoLSelected = partido.Local.Id;
            equipoVOption = new SelectList(_repoEquipoVisitante.GetAllEquipos(), "Id", "Nombre");
            equipoVSelected = partido.Visitante.Id;
            if (partido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Partido partido, int idEquipoLocal, int idEquipoVisitante)
        {
            _repoPartido.UpdatePartido(partido, idEquipoLocal, idEquipoVisitante);
            return RedirectToPage("Index");
        }
    }
}

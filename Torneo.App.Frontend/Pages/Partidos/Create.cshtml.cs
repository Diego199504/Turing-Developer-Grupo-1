using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Partidos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipoLocal;
        private readonly IRepositorioEquipo _repoEquipoVisitante;

        public Partido partido { get; set; }
        public IEnumerable<Equipo> local { get; set; }
        public IEnumerable<Equipo> visitante { get; set; }

        public CreateModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipoLocal,
        IRepositorioEquipo repoEquipoVisitante)
        {
            _repoPartido = repoPartido;
            _repoEquipoLocal = repoEquipoLocal;
            _repoEquipoVisitante = repoEquipoVisitante;
        }

        public void OnGet()
        {
            partido = new Partido();
            local = _repoEquipoLocal.GetAllEquipos();
            visitante = _repoEquipoVisitante.GetAllEquipos();
        }

        public IActionResult OnPost(Partido partido, int idEquipoLocal, int idEquipoVisitante)
        {
            _repoPartido.AddPartido(partido, idEquipoLocal, idEquipoVisitante);
            return RedirectToPage("Index");
        }
    }
}

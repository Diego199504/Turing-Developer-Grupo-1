using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Torneo.App.Frontend.Pages.Jugador
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioJugador _repojugador;
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioPosicion _repoPosicion;

        public Jugadores jugador { get; set; }
        public SelectList equipoOption { get; set; }
        public SelectList posicionOption { get; set; }
        public int equipoSelected { get; set; }
        public int posicionSelected { get; set; }

        public EditModel(IRepositorioJugador repojugador, IRepositorioEquipo repoEquipo, IRepositorioPosicion repoPosicion)
        {
            _repojugador = repojugador;
            _repoEquipo = repoEquipo;
            _repoPosicion = repoPosicion;
        }
        public IActionResult OnGet(int id)
        {
            jugador = _repojugador.GetJugador(id);
            equipoOption = new SelectList(_repoEquipo.GetAllEquipos(), "Id", "Nombre");
            equipoSelected = jugador.Equipo.Id;
            posicionOption = new SelectList(_repoPosicion.GetAllPosiciones(), "Id", "Nombre");
            posicionSelected = jugador.Posicion.Id;
            if (jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Jugadores jugador, int idEquipo, int idPosicion)
        {
            _repojugador.UpdateJugador(jugador, idEquipo, idPosicion);
            return RedirectToPage("Index");
        }
    }
}
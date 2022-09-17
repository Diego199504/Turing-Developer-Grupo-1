using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;


namespace Torneo.App.Frontend.Pages.Jugador
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioPosicion _repoPosicion;

        public Jugadores jugador { get; set; }
        public IEnumerable<Equipo> equipo { get; set; }
        public IEnumerable<Posicion> posicion { get; set; }
        public CreateModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo, IRepositorioPosicion repoPosicion)
        {
            _repoJugador = repoJugador;
            _repoEquipo = repoEquipo;
            _repoPosicion = repoPosicion;
        }
        public void OnGet()
        {
            jugador = new Jugadores();
            equipo = _repoEquipo.GetAllEquipos();
            posicion = _repoPosicion.GetAllPosiciones();
        }
        public IActionResult OnPost(Jugadores jugador, int idEquipo, int idPosicion)
        {
            _repoJugador.AddJugador(jugador, idEquipo, idPosicion);
            return RedirectToPage("Index");
        }

    }
}

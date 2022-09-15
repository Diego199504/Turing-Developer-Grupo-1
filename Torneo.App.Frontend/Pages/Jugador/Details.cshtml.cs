using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Jugador
{

    public class DetailsModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugadores jugador {get; set;}
        public DetailsModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public IActionResult OnGet(int id)
        {
           jugador = _repoJugador.GetJugador(id);
           if (jugador == null){
            return NotFound();
           }
           else{
            return Page();
           }
        }
    }
}

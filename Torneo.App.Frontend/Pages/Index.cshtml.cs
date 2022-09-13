using Torneo.App.Persistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Torneo.App.Frontend.Pages.Partido;

public class IndexModel : PageModel
{
    private readonly IRepositorioPartido _repoPartido;
    public IEnumerable<Dominio.Partido> Partido { get; set; }

    public IndexModel(IRepositorioPartido repoPartido)
    {
        _repoPartido = repoPartido;
    }

    public void OnGet()
    {
        Partido = _repoPartido.GetAllPartidos();
    }
}

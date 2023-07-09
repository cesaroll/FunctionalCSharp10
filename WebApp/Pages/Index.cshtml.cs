using Application.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.Types;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IReadOnlyRepository<Part> _parts;

    public IndexModel(ILogger<IndexModel> logger, IReadOnlyRepository<Part> parts)
    {
        _logger = logger;
        _parts = parts;
    }

    public IEnumerable<Part> AllPArts {get; set;} = Enumerable.Empty<Part>();

    public void OnGet()
    {
        this.AllPArts = _parts.GetAll().ToList();
    }
}

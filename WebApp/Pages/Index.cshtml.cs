using Application.Persistance;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.Types;
using Models.Media;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IReadOnlyRepository<Part> Parts;

    public IndexModel(ILogger<IndexModel> logger, IReadOnlyRepository<Part> parts)
    {
        _logger = logger;
        Parts = parts;
    }

    void F()
    {
        Part part = new(new Guid(), "Something", new("SOMESKU"));
        part.Sku.ToCode39(25);
    }

    public IEnumerable<Part> AllPArts {get; set;} = Enumerable.Empty<Part>();

    public void OnGet()
    {
        this.AllPArts = Parts.GetAll().ToList();
    }
}

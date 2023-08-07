using Application.Persistance;
using Models.Types;
using Models.Types.Common;

namespace TestPersistance;

public class Inventory : IReadOnlyRepository<(Part part, DiscreteMeasure quantity)>
{
    private PartsReadRepository Parts {get;} = new();

    public IEnumerable<(Part part, DiscreteMeasure quantity)> TryFind(Guid id) =>
        this.Parts.TryFind(id).Filer(Exists).Map(part => (part, QuantityFor(part)));

    public static DiscreteMeasure QuantityFor(Part part) =>
        new("Piece", Exists(part) ? 1U : 0);

    public IEnumerable<(Part part, DiscreteMeasure quantity)> GetAll() =>
        this.Parts.GetAll().Where(Exists).Select(part => (part, QuantityFor(part)));

    private static bool Exists(Part part) => part.Sku.Value[part.Sku.Value.Length / 2] % 5 == 2;
}

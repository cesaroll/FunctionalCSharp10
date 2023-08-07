using Application.Persistance;
using Models.Types;
using Models.Types.Common;

namespace TestPersistance;

public class PartsReadRepository : IReadOnlyRepository<Part>
{
    public IEnumerable<Part> GetAll() => new[]
    {
        new Part (Guid.NewGuid(), "Bobina 123", new StockKeepingUnit("BOB123")),
        new Part (Guid.NewGuid(), "Transistor 4456", new StockKeepingUnit("TR456")),
        new Part (Guid.NewGuid(), "Resistencia 45654", new StockKeepingUnit("RES4654")),
        new Part (Guid.NewGuid(), "LED Amarillo 111", new StockKeepingUnit("LEDA111")),
        new Part (Guid.NewGuid(), "LED Rojo 222", new StockKeepingUnit("LEDR222")),
        new Part (Guid.NewGuid(), "LED Verde 333", new StockKeepingUnit("LEDV333")),
        new Part (Guid.NewGuid(), "Capacitor 230uF 25v", new StockKeepingUnit("CAP230UF25V")),
        new Part (Guid.NewGuid(), "Capacitor 130uF 25v", new StockKeepingUnit("CAP130UF25V")),
        new Part (Guid.NewGuid(), "Bateria 9V", new StockKeepingUnit("BAT9V")),
        new Part (Guid.NewGuid(), "Bateria 1.5V", new StockKeepingUnit("BAT1.5V"))
    };

    public Option<Part> TryFind(Guid id) => GetAll()
        .Where(part => part.Id == id)
        .Select(part => part.Optional())
        .SingleOrDefault(None.Value);
}

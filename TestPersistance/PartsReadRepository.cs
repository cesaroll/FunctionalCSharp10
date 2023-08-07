using Application.Persistance;
using Models.Types;

namespace TestPersistance;

public class PartsReadRepository : IReadOnlyRepository<Part>
{
    public IEnumerable<Part> GetAll() => new[]
    {
        new Part (new Guid(), "Bobina 123", new StockKeepingUnit("BOB123")),
        new Part (new Guid(), "Transistor 4456", new StockKeepingUnit("TR456")),
        new Part (new Guid(), "Resistencia 45654", new StockKeepingUnit("RES4654")),
        new Part (new Guid(), "LED Amarillo 111", new StockKeepingUnit("LEDA111")),
        new Part (new Guid(), "LED Rojo 222", new StockKeepingUnit("LEDR222")),
        new Part (new Guid(), "LED Verde 333", new StockKeepingUnit("LEDV333")),
        new Part (new Guid(), "Capacitor 230uF 25v", new StockKeepingUnit("CAP230UF25V")),
        new Part (new Guid(), "Capacitor 130uF 25v", new StockKeepingUnit("CAP130UF25V")),
        new Part (new Guid(), "Bateria 9V", new StockKeepingUnit("BAT9V")),
        new Part (new Guid(), "Bateria 1.5V", new StockKeepingUnit("BAT1.5V"))
    };

    public IEnumerable<Part> TryFind(Guid id) => GetAll().Where(part => part.Id == id);
}
